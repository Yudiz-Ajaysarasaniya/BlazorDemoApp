using BlazorDemoApp.Context;
using BlazorDemoApp.Models.Entities;
using BlazorDemoApp.Models.Request;
using Microsoft.EntityFrameworkCore;

namespace BlazorDemoApp.Services
{
    public class UserService
    {
        private readonly AppDbContext _context;

        public UserService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<string> PersistUsers(UserPersistRequest request)
        {
            if(string.IsNullOrEmpty(request.Email)) return "Email is required";
            if(string.IsNullOrEmpty(request.Name)) return "Name is required";
            if(string.IsNullOrEmpty(request.Password)) return "Password is required";

            var existingUser = await _context.Users.FirstOrDefaultAsync(u => u.Email == request.Email);

            if(existingUser != null)
            {
                existingUser.Name = request.Name;
                existingUser.Password = request.Password;
                existingUser.Email = request.Email;

                _context.Users.Update(existingUser);

                await _context.SaveChangesAsync();
                return "User updated successfully";
            }

                var user = new UserEntity
                {
                    Name = request.Name,
                    Email = request.Email,
                    Password = request.Password
                };

                await _context.Users.AddAsync(user);
                await _context.SaveChangesAsync();

            return "User added successfully";
                
            //if (_context.Users.Any(u => u.Email == user.Email))
            //{
            //    return "User already exists";
            //}
            //else
            //{
                

            //    return "User added successfully";
            //}
        }

        public async Task<List<UserEntity>> GetUsers()
        {
            var users = await _context.Users.ToListAsync();
            return users;
        }

        public async Task<string> DeleteUser(Guid userId)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == userId);

            if (user == null)
                return "User not found";

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return "User deleted successfully";
        }

    }
}
