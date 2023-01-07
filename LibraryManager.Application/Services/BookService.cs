using AutoMapper;
using FluentValidation.Results;
using LibraryManager.Application.DTOs;
using LibraryManager.Application.ErrorHandler;
using LibraryManager.Application.Interfaces.Services;
using LibraryManager.Application.ValidationHandler;
using LibraryManager.Domain.Interfaces.Repositories;
using LibraryManager.Domain.Models;
using LibraryManager.Domain.Validators;
using Microsoft.EntityFrameworkCore;

namespace LibraryManager.Application.Services
{
    public class BookService : IBookService
    {
        private readonly IPublisherRepository _publisherRepository;
        private readonly IMapper _mapper;

        public BookService(IPublisherRepository publisherRepository, IMapper mapper)
        {
            _publisherRepository = publisherRepository;
            _mapper = mapper;
        }

        public async Task<Publisher> GetBooksByPublisherName(string publisherName)
        {
            return await _publisherRepository.GetPublisherByNameWithBooks(publisherName);
        }

        public async Task<IEnumerable<Publisher>> GetPublishers()
        {
            return await _publisherRepository.GetAll();
        }

        public async Task<DatabaseOperationResult> AddPublisher(PublisherAddDTO publisherDTO)
        {
            Publisher publisher = _mapper.Map<Publisher>(publisherDTO);

            DatabaseOperationResult operationResult = new();
            DomainErrorProcessor<Publisher>.Validate(publisher, new PublisherValidator(), operationResult);

            if (!operationResult.IsSuccess)
                return operationResult;

            try
            {
                await _publisherRepository.Add(publisher);
                operationResult.IsSuccess = true;
            }
            catch (DbUpdateException exception)
            {
                operationResult.IsSuccess = false;

                if (exception.InnerException is not null)
                    operationResult.Errors.Add(exception.InnerException.Message);
                else
                    operationResult.Errors.Add(exception.Message);
            }
            catch (Exception)
            {
                operationResult.IsSuccess = false;
                operationResult.Errors.Add("Unexpected Error");
            }

            return operationResult;
        }

        public async Task<DatabaseOperationResult> UpdatePublisher(PublisherUpdateDTO publisherDTO)
        {
            Publisher publisher = _mapper.Map<Publisher>(publisherDTO);

            DatabaseOperationResult operationResult = new();
            DomainErrorProcessor<Publisher>.Validate(publisher, new PublisherValidator(), operationResult);

            if (!operationResult.IsSuccess)
                return operationResult;

            try
            {
                Publisher? publisherToUpdate = await _publisherRepository.GetById(publisher.PublisherId);

                if (publisherToUpdate is not null)
                {
                    _mapper.Map(publisherDTO, publisherToUpdate);
                    await _publisherRepository.Update(publisherToUpdate);

                    operationResult.IsSuccess = true;
                    return operationResult;
                }

                operationResult.Errors.Add("Publisher doesn't exist");
            }
            catch (DbUpdateException exception)
            {
                operationResult.IsSuccess = false;

                if (exception.InnerException is not null)
                    operationResult.Errors.Add(exception.InnerException.Message);
                else
                    operationResult.Errors.Add(exception.Message);
            }
            catch (Exception)
            {
                operationResult.IsSuccess = false;
                operationResult.Errors.Add("Unexpected Error");
            }

            return operationResult;
        }

        public async Task DeletePublisher(string publisherName)
        {
            Publisher? publisher = await _publisherRepository.GetByPublisherName(publisherName);

            if (publisher is not null)
                await _publisherRepository.Delete(publisher);
        }
    }
}
