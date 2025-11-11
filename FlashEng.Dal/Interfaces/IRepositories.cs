using FlashEng.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FlashEng.Dal.Interfaces
{
    public interface IUserRepository
    {
        Task<List<User>> GetAllUsersAsync(CancellationToken cancellationToken = default(CancellationToken));
        Task<User> GetUserByIdAsync(int userId, CancellationToken cancellationToken = default(CancellationToken));
        Task<User> GetUserByEmailAsync(string email, CancellationToken cancellationToken = default(CancellationToken));
        Task<int> CreateUserAsync(User user, CancellationToken cancellationToken = default(CancellationToken));
        Task<bool> UpdateUserAsync(User user, CancellationToken cancellationToken = default(CancellationToken));
        Task<bool> DeleteUserAsync(int userId, CancellationToken cancellationToken = default(CancellationToken));
        Task<UserSettings> GetUserSettingsAsync(int userId, CancellationToken cancellationToken = default(CancellationToken));
        Task<int> CreateUserSettingsAsync(UserSettings settings, CancellationToken cancellationToken = default(CancellationToken));
        Task<bool> UpdateUserSettingsAsync(UserSettings settings, CancellationToken cancellationToken = default(CancellationToken));
    }

    public interface IFlashcardRepository
    {
        Task<List<Flashcard>> GetAllFlashcardsAsync(CancellationToken cancellationToken = default(CancellationToken));
        Task<List<Flashcard>> GetUserFlashcardsAsync(int userId, CancellationToken cancellationToken = default(CancellationToken));
        Task<Flashcard> GetFlashcardByIdAsync(int flashcardId, CancellationToken cancellationToken = default(CancellationToken));
        Task<List<Flashcard>> GetFlashcardsByCategoryAsync(string category, CancellationToken cancellationToken = default(CancellationToken));
        Task<List<Flashcard>> SearchFlashcardsAsync(string searchTerm, CancellationToken cancellationToken = default(CancellationToken));
        Task<int> CreateFlashcardAsync(Flashcard flashcard, CancellationToken cancellationToken = default(CancellationToken));
        Task<bool> UpdateFlashcardAsync(Flashcard flashcard, CancellationToken cancellationToken = default(CancellationToken));
        Task<bool> DeleteFlashcardAsync(int flashcardId, CancellationToken cancellationToken = default(CancellationToken));
        Task<List<string>> GetAllCategoriesAsync(CancellationToken cancellationToken = default(CancellationToken));
    }

    public interface IOrderRepository
    {
        Task<List<Order>> GetAllOrdersAsync(CancellationToken cancellationToken = default(CancellationToken));
        Task<Order> GetOrderByIdAsync(int orderId, CancellationToken cancellationToken = default(CancellationToken));
        Task<List<Order>> GetUserOrdersAsync(int userId, CancellationToken cancellationToken = default(CancellationToken));
        Task<int> CreateOrderAsync(Order order, CancellationToken cancellationToken = default(CancellationToken));
        Task<bool> UpdateOrderAsync(Order order, CancellationToken cancellationToken = default(CancellationToken));
        Task<bool> DeleteOrderAsync(int orderId, CancellationToken cancellationToken = default(CancellationToken));
        Task<List<OrderItem>> GetOrderItemsAsync(int orderId, CancellationToken cancellationToken = default(CancellationToken));
        Task<int> CreateOrderItemAsync(OrderItem orderItem, CancellationToken cancellationToken = default(CancellationToken));
        Task<List<Product>> GetAllProductsAsync(CancellationToken cancellationToken = default(CancellationToken));
        Task<Product> GetProductByIdAsync(int productId, CancellationToken cancellationToken = default(CancellationToken));
        Task<int> CreateOrderWithItemsAsync(int userId, List<(int productId, int quantity)> items, CancellationToken cancellationToken = default(CancellationToken));
    }

    public interface IUnitOfWork : IDisposable
    {
        IUserRepository Users { get; }
        IFlashcardRepository Flashcards { get; }
        IOrderRepository Orders { get; }

        Task BeginTransactionAsync(CancellationToken cancellationToken = default(CancellationToken));
        Task CommitAsync(CancellationToken cancellationToken = default(CancellationToken));
        Task RollbackAsync(CancellationToken cancellationToken = default(CancellationToken));
    }
}