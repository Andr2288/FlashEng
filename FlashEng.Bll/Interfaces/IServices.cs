using FlashEng.Bll.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FlashEng.Bll.Interfaces
{
    public interface IUserService
    {
        Task<List<UserDto>> GetAllUsersAsync(CancellationToken cancellationToken = default(CancellationToken));
        Task<UserDto> GetUserByIdAsync(int userId, CancellationToken cancellationToken = default(CancellationToken));
        Task<UserDto> GetUserByEmailAsync(string email, CancellationToken cancellationToken = default(CancellationToken));
        Task<int> CreateUserAsync(CreateUserDto createUserDto, CancellationToken cancellationToken = default(CancellationToken));
        Task<bool> UpdateUserAsync(int userId, UpdateUserDto updateUserDto, CancellationToken cancellationToken = default(CancellationToken));
        Task<bool> DeleteUserAsync(int userId, CancellationToken cancellationToken = default(CancellationToken));
        Task<UserSettingsDto> GetUserSettingsAsync(int userId, CancellationToken cancellationToken = default(CancellationToken));
        Task<bool> UpdateUserSettingsAsync(int userId, UserSettingsDto settingsDto, CancellationToken cancellationToken = default(CancellationToken));
    }

    public interface IFlashcardService
    {
        Task<List<FlashcardDto>> GetAllFlashcardsAsync(CancellationToken cancellationToken = default(CancellationToken));
        Task<List<FlashcardDto>> GetUserFlashcardsAsync(int userId, CancellationToken cancellationToken = default(CancellationToken));
        Task<FlashcardDto> GetFlashcardByIdAsync(int flashcardId, CancellationToken cancellationToken = default(CancellationToken));
        Task<List<FlashcardDto>> GetFlashcardsByCategoryAsync(string category, CancellationToken cancellationToken = default(CancellationToken));
        Task<List<FlashcardDto>> SearchFlashcardsAsync(string searchTerm, CancellationToken cancellationToken = default(CancellationToken));
        Task<int> CreateFlashcardAsync(CreateFlashcardDto createFlashcardDto, CancellationToken cancellationToken = default(CancellationToken));
        Task<bool> UpdateFlashcardAsync(int flashcardId, UpdateFlashcardDto updateFlashcardDto, CancellationToken cancellationToken = default(CancellationToken));
        Task<bool> DeleteFlashcardAsync(int flashcardId, CancellationToken cancellationToken = default(CancellationToken));
        Task<List<string>> GetAllCategoriesAsync(CancellationToken cancellationToken = default(CancellationToken));
    }

    public interface IOrderService
    {
        Task<List<OrderDto>> GetAllOrdersAsync(CancellationToken cancellationToken = default(CancellationToken));
        Task<OrderDto> GetOrderByIdAsync(int orderId, CancellationToken cancellationToken = default(CancellationToken));
        Task<List<OrderDto>> GetUserOrdersAsync(int userId, CancellationToken cancellationToken = default(CancellationToken));
        Task<int> CreateOrderAsync(CreateOrderDto createOrderDto, CancellationToken cancellationToken = default(CancellationToken));
        Task<bool> UpdateOrderStatusAsync(int orderId, string status, CancellationToken cancellationToken = default(CancellationToken));
        Task<bool> DeleteOrderAsync(int orderId, CancellationToken cancellationToken = default(CancellationToken));
        Task<List<ProductDto>> GetAllProductsAsync(CancellationToken cancellationToken = default(CancellationToken));
        Task<ProductDto> GetProductByIdAsync(int productId, CancellationToken cancellationToken = default(CancellationToken));
        Task<int> CreateOrderWithItemsTransactionalAsync(CreateOrderDto createOrderDto, CancellationToken cancellationToken = default(CancellationToken));
    }
}