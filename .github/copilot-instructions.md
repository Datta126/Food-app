
🍕  FoodieApp
Zomato-Style Food Delivery Web Application
Complete GitHub Copilot Build Instructions

📋  HOW TO USE THIS DOCUMENT
Save this file in your project root as:  .github/copilot-instructions.md
Open GitHub Copilot Chat in VS Code and switch to AGENT MODE
Type exactly:  "Do Step 1"  →  wait for Copilot to finish
Run  dotnet build  after each step — fix any errors before continuing
Type  "Do Step 2"  →  continue until Step 20 is complete

⚠️  Never skip a step. Each step builds on the previous one.

📦  What We Are Building
A complete food delivery web application like Zomato, built with ASP.NET Core 8, Entity Framework Core, Blazor WebAssembly, SignalR, Redis, and Stripe. The app supports customers, restaurant owners, delivery agents, and admins.

Tech Stack
Features
User Roles
• ASP.NET Core 8 Web API
• Blazor WebAssembly
• Entity Framework Core 8
• SQL Server Express
• Redis (cart + cache)
• SignalR (real-time)
• Stripe (payments)
• Cloudinary (images)
• Hangfire (jobs)
• MudBlazor (UI)
• Google Maps API
• Restaurant discovery & search
• Real-time order tracking
• Live Google Maps agent tracking
• In-app customer ↔ agent chat
• Stripe card payments
• Wallet & loyalty points
• Push notifications (PWA)
• Coupon / offer system
• Review & rating system
• Background job automation
• Full admin dashboard
👤  Customer
   Order food, track delivery

🏪  Restaurant Owner
   Manage menu, accept orders

🛵  Delivery Agent
   Accept & deliver orders

🔧  Admin
   Full platform control

💬  Support Agent
   Handle tickets


STEP 1: CREATE SOLUTION & INSTALL ALL PACKAGES
▶  To start this step, type in Copilot:  "Do Step 1"

Create the full .NET 8 solution with 6 projects and install every required NuGet package.

1.1  Run These Commands in the Terminal
💡 Open a terminal in VS Code (Ctrl + `) and run every command below in order.

Create solution and all projects:
  
dotnet new sln -n FoodieApp
dotnet new webapi   -n FoodieApp.API           --framework net8.0
dotnet new classlib -n FoodieApp.Core          --framework net8.0
dotnet new classlib -n FoodieApp.Application   --framework net8.0
dotnet new classlib -n FoodieApp.Infrastructure --framework net8.0
dotnet new classlib -n FoodieApp.Shared        --framework net8.0
dotnet new blazorwasm -n FoodieApp.BlazorUI    --framework net8.0
  

Add all projects to solution:
  
dotnet sln add FoodieApp.API/FoodieApp.API.csproj
dotnet sln add FoodieApp.Core/FoodieApp.Core.csproj
dotnet sln add FoodieApp.Application/FoodieApp.Application.csproj
dotnet sln add FoodieApp.Infrastructure/FoodieApp.Infrastructure.csproj
dotnet sln add FoodieApp.Shared/FoodieApp.Shared.csproj
dotnet sln add FoodieApp.BlazorUI/FoodieApp.BlazorUI.csproj
  

Add project references (dependency chain):
  
dotnet add FoodieApp.API/FoodieApp.API.csproj reference FoodieApp.Application/FoodieApp.Application.csproj
dotnet add FoodieApp.API/FoodieApp.API.csproj reference FoodieApp.Infrastructure/FoodieApp.Infrastructure.csproj
dotnet add FoodieApp.Application/FoodieApp.Application.csproj reference FoodieApp.Core/FoodieApp.Core.csproj
dotnet add FoodieApp.Infrastructure/FoodieApp.Infrastructure.csproj reference FoodieApp.Core/FoodieApp.Core.csproj
dotnet add FoodieApp.Infrastructure/FoodieApp.Infrastructure.csproj reference FoodieApp.Application/FoodieApp.Application.csproj
dotnet add FoodieApp.BlazorUI/FoodieApp.BlazorUI.csproj reference FoodieApp.Shared/FoodieApp.Shared.csproj
  

Install NuGet packages for API + Infrastructure:
  
dotnet add FoodieApp.API package Microsoft.EntityFrameworkCore.SqlServer --version 8.0.0
dotnet add FoodieApp.API package Microsoft.EntityFrameworkCore.Tools --version 8.0.0
dotnet add FoodieApp.API package Microsoft.AspNetCore.Authentication.JwtBearer --version 8.0.0
dotnet add FoodieApp.API package Microsoft.AspNetCore.Identity.EntityFrameworkCore --version 8.0.0
dotnet add FoodieApp.API package AutoMapper.Extensions.Microsoft.DependencyInjection --version 12.0.1
dotnet add FoodieApp.API package FluentValidation.AspNetCore --version 11.3.0
dotnet add FoodieApp.API package Serilog.AspNetCore --version 8.0.0
dotnet add FoodieApp.API package Serilog.Sinks.Console --version 5.0.1
dotnet add FoodieApp.API package Serilog.Sinks.File --version 5.0.0
dotnet add FoodieApp.API package StackExchange.Redis --version 2.7.10
dotnet add FoodieApp.API package Microsoft.Extensions.Caching.StackExchangeRedis --version 8.0.0
dotnet add FoodieApp.API package Swashbuckle.AspNetCore --version 6.5.0
dotnet add FoodieApp.API package Microsoft.AspNetCore.SignalR.StackExchangeRedis --version 8.0.0
dotnet add FoodieApp.API package CloudinaryDotNet --version 1.26.2
dotnet add FoodieApp.API package Stripe.net --version 43.11.0
dotnet add FoodieApp.API package Twilio --version 7.0.0
dotnet add FoodieApp.API package Hangfire --version 1.8.6
dotnet add FoodieApp.API package Hangfire.AspNetCore --version 1.8.6
dotnet add FoodieApp.API package Hangfire.SqlServer --version 1.8.6
dotnet add FoodieApp.API package MediatR --version 12.2.0
dotnet add FoodieApp.API package FluentEmail.Core --version 3.0.2
dotnet add FoodieApp.API package FluentEmail.Smtp --version 3.0.2
dotnet add FoodieApp.API package ClosedXML --version 0.102.2
dotnet add FoodieApp.API package Google.Apis.Auth --version 1.67.0
dotnet add FoodieApp.API package Newtonsoft.Json --version 13.0.3
dotnet add FoodieApp.API package Microsoft.AspNetCore.RateLimiting --version 8.0.0
  

Install NuGet packages for BlazorUI:
  
dotnet add FoodieApp.BlazorUI package Blazored.LocalStorage --version 4.4.0
dotnet add FoodieApp.BlazorUI package Blazored.Toast --version 4.2.1
dotnet add FoodieApp.BlazorUI package Microsoft.AspNetCore.SignalR.Client --version 8.0.0
dotnet add FoodieApp.BlazorUI package MudBlazor --version 6.11.2
dotnet add FoodieApp.BlazorUI package Newtonsoft.Json --version 13.0.3
dotnet add FoodieApp.BlazorUI package Microsoft.AspNetCore.Components.WebAssembly.Authentication --version 8.0.0
  

Verify build — must show 0 errors:
  
dotnet build
  
💡 Stop and fix every error before continuing to Step 2.


STEP 2: CREATE ALL ENUMS AND BASE ENTITIES
▶  To start this step, type in Copilot:  "Do Step 2"

Define all shared enums and the base entity classes used by every other entity.

2.1  Create Folder Structure in FoodieApp.Core
  
FoodieApp.Core/
  Entities/
  Enums/
  Interfaces/
  Constants/
  

2.2  Create File:  FoodieApp.Core/Enums/AllEnums.cs
  
namespace FoodieApp.Core.Enums
{
    public enum UserGender          { Male, Female, Other, PreferNotToSay }
    public enum AddressLabel        { Home, Work, Other }
    public enum OrderStatus         { Pending, Confirmed, Preparing, ReadyForPickup, PickedUp, OutForDelivery, Delivered, Cancelled, Rejected }
    public enum PaymentStatus       { Pending, Paid, Failed, Refunded }
    public enum PaymentMethod       { CashOnDelivery, Card, UPI, NetBanking, Wallet }
    public enum SpicyLevel          { NotSpicy, Mild, Medium, Hot, ExtraHot }
    public enum VehicleType         { Bicycle, Motorcycle, Scooter, Car }
    public enum DiscountType        { Percentage, FlatAmount }
    public enum OfferApplicability  { AllUsers, NewUsersOnly, SelectedUsers }
    public enum SupportTicketStatus { Open, InProgress, Resolved, Closed }
    public enum SupportPriority     { Low, Medium, High, Critical }
    public enum NotificationType    { OrderUpdate, OfferAlert, AccountUpdate, General }
    public enum WalletTransactionType   { Credit, Debit }
    public enum WalletTransactionSource { Refund, ReferralBonus, Cashback, AdminCredit, OrderPayment, WalletTopup }
    public enum LoyaltyTransactionType  { Earned, Redeemed, Expired }
    public enum MessageSenderType   { Customer, DeliveryAgent, SupportAgent, Admin, System }
    public enum AgentVerificationStatus { Pending, Verified, Rejected, Suspended }
    public enum RestaurantSortBy    { Relevance, Rating, DeliveryTime, CostLowToHigh, CostHighToLow, Distance }
    public enum DayOfWeekCustom     { Monday=1, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }
}
  

2.3  Create File:  FoodieApp.Core/Entities/BaseEntity.cs
  
namespace FoodieApp.Core.Entities
{
    public abstract class BaseEntity
    {
        public Guid Id          { get; set; } = Guid.NewGuid();
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        public bool IsDeleted   { get; set; } = false;
        public DateTime? DeletedAt { get; set; }
    }
 
    public abstract class AuditableEntity : BaseEntity
    {
        public Guid? CreatedBy { get; set; }
        public Guid? UpdatedBy { get; set; }
    }
}
  

2.4  Create File:  FoodieApp.Core/Constants/AppConstants.cs
  
namespace FoodieApp.Core.Constants
{
    public static class AppConstants
    {
        public const string AdminRole           = "Admin";
        public const string CustomerRole        = "Customer";
        public const string RestaurantOwnerRole = "RestaurantOwner";
        public const string DeliveryAgentRole   = "DeliveryAgent";
        public const string SupportAgentRole    = "SupportAgent";
        public const decimal PlatformFeePercent = 2m;
        public const decimal TaxPercent         = 5m;
        public const int OtpExpiryMinutes       = 5;
        public const int MaxFileSizeMb          = 5;
        public const string DefaultCurrency     = "inr";
        public const string DefaultCountry      = "India";
    }
}
  

Run after Step 2:
  
dotnet build   ← must show 0 errors
  

STEP 3: CREATE ALL DOMAIN ENTITIES
▶  To start this step, type in Copilot:  "Do Step 3"

Create every database entity class with all properties, relationships, and navigation properties.

💡 First install Identity in FoodieApp.Core:  dotnet add FoodieApp.Core package Microsoft.AspNetCore.Identity.EntityFrameworkCore --version 8.0.0
3.1  What Copilot Must Create
Create one file per entity group inside FoodieApp.Core/Entities/. Every property listed below must be included. Do not use placeholder comments.

File Name
Entities Inside
Extends
ApplicationUser.cs
ApplicationUser
IdentityUser<Guid>
RefreshToken.cs
RefreshToken
BaseEntity
UserAddress.cs
UserAddress
BaseEntity
Restaurant.cs
Restaurant
AuditableEntity
RestaurantOpeningHour.cs
RestaurantOpeningHour
BaseEntity
MenuEntities.cs
Cuisine, RestaurantCuisine, Tag, RestaurantTag, MenuCategory, MenuItem, MenuItemCustomization, CustomizationOption, MenuItemAddOn
BaseEntity / AuditableEntity
OrderEntities.cs
Cart, CartItem, Order, OrderItem, OrderTracking
BaseEntity / AuditableEntity
ReviewEntities.cs
Review, ReviewImage
AuditableEntity / BaseEntity
OtherEntities.cs
Offer, OfferUsage, DeliveryAgent, Notification, FavoriteRestaurant, RestaurantBanner, PlatformBanner, WalletTransaction, LoyaltyTransaction, SupportTicket, SupportMessage, ChatMessage, City, SystemSetting, AuditLog
BaseEntity / AuditableEntity

3.2  Rules Copilot Must Follow When Creating Entities
Every entity that extends BaseEntity must have: Id(Guid), CreatedAt, UpdatedAt, IsDeleted, DeletedAt
Every entity that extends AuditableEntity must add: CreatedBy(Guid?), UpdatedBy(Guid?)
All decimal money fields must be typed as decimal (not double or float)
All navigation properties must be virtual and initialized (e.g. = new List<>())
ApplicationUser must include navigation collections for: Addresses, Orders, Reviews, FavoriteRestaurants, Notifications, WalletTransactions, LoyaltyTransactions, RefreshTokens
Restaurant entity must include: IsActive, IsApproved, IsFeatured, IsPureVeg, IsAcceptingOrders, AverageRating, TotalReviews, TotalOrders, Latitude, Longitude, Slug
Order entity must include all timestamps: OrderPlacedAt, ConfirmedAt, PreparingAt, ReadyAt, PickedUpAt, DeliveredAt, CancelledAt
MenuItem must include: IsVeg, IsVegan, IsSpicy, SpicyLevel, IsBestSeller, IsAvailable, Price, DiscountedPrice
FavoriteRestaurant and RestaurantCuisine and RestaurantTag must use composite primary keys

Run after Step 3:
  
dotnet build   ← must show 0 errors
  

STEP 4: CREATE DATABASE CONTEXT & REPOSITORIES
▶  To start this step, type in Copilot:  "Do Step 4"

Create AppDbContext, all entity configurations, repository pattern, Unit of Work, and seed data.

4.1  AppDbContext  —  FoodieApp.Infrastructure/Data/AppDbContext.cs
Extend IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
Add DbSet<T> for every entity created in Step 3
Override SaveChangesAsync: auto-set UpdatedAt = UtcNow on every save
Override SaveChangesAsync: auto-set IsDeleted = true and DeletedAt = UtcNow on soft delete
Add global query filter .HasQueryFilter(e => !e.IsDeleted) on all soft-deletable entities

4.2  Entity Configurations  —  FoodieApp.Infrastructure/Data/Configurations/
Create one IEntityTypeConfiguration<T> class per entity
RestaurantConfiguration: index on Slug(unique), City, IsActive+IsApproved, AverageRating, Latitude+Longitude
OrderConfiguration: index on OrderNumber(unique), UserId, RestaurantId, Status, OrderPlacedAt
ApplicationUserConfiguration: unique indexes on Email, PhoneNumber, ReferralCode
All decimal money columns: .HasPrecision(18,2)
All string columns: set max length (.HasMaxLength)
FavoriteRestaurant: .HasKey(f => new { f.UserId, f.RestaurantId })
RestaurantCuisine: .HasKey(rc => new { rc.RestaurantId, rc.CuisineId })
RestaurantTag: .HasKey(rt => new { rt.RestaurantId, rt.TagId })

4.3  Repository Pattern
Create IGenericRepository<T> in FoodieApp.Core/Interfaces/ with methods: GetByIdAsync, GetAllAsync, FindAsync, FindAllAsync, GetPagedAsync, AddAsync, AddRangeAsync, UpdateAsync, SoftDeleteAsync, ExistsAsync, CountAsync
Create GenericRepository<T> in FoodieApp.Infrastructure/Repositories/ — full implementation using AppDbContext
Create IUnitOfWork in FoodieApp.Core/Interfaces/ with a repository property for every entity and: SaveChangesAsync, BeginTransactionAsync, CommitTransactionAsync, RollbackTransactionAsync
Create UnitOfWork in FoodieApp.Infrastructure/Repositories/ — full implementation

4.4  Seed Data  —  FoodieApp.Infrastructure/Data/DataSeeder.cs
5 Roles: Admin, Customer, RestaurantOwner, DeliveryAgent, SupportAgent
1 Admin user: admin@foodieapp.com / Admin@123456 with Admin role
10 Cities: Mumbai, Delhi, Bangalore, Hyderabad, Chennai, Pune, Kolkata, Ahmedabad, Jaipur, Surat
10 Cuisines: Indian, Chinese, Italian, Mexican, Continental, Thai, Japanese, American, South Indian, Fast Food
5 Tags: Top Rated, Trending, New, Pure Veg, Fast Delivery
Platform SystemSettings: PlatformFeePercent=2, TaxPercent=5, MinDeliveryCharge=20, FreeDeliveryAbove=500

4.5  Run EF Migrations
  
dotnet ef migrations add InitialCreate --project FoodieApp.Infrastructure --startup-project FoodieApp.API
dotnet ef database update             --project FoodieApp.Infrastructure --startup-project FoodieApp.API
  
💡 If EF tools are not installed, run:  dotnet tool install --global dotnet-ef

Run after Step 4:
  
dotnet build   ← must show 0 errors
  

STEP 5: CREATE ALL SERVICE INTERFACES & DTOs
▶  To start this step, type in Copilot:  "Do Step 5"

Define all Data Transfer Objects and service interfaces before writing implementations.

5.1  Create DTO Folder Structure in FoodieApp.Application/DTOs/
  
DTOs/
  Common/     ← ApiResponse.cs, PagedResult.cs
  Auth/       ← RegisterDto, LoginDto, LoginResponseDto, RefreshTokenDto, etc.
  User/       ← UserProfileDto, UpdateProfileDto, UserAddressDto, WalletDto
  Restaurant/ ← RestaurantCardDto, RestaurantDetailDto, CreateRestaurantDto, RestaurantFilterDto
  Menu/       ← MenuCategoryDto, MenuItemDto, CreateMenuItemDto, CustomizationDto
  Cart/       ← CartDto, CartItemDto, AddToCartDto, CartSummaryDto
  Order/      ← PlaceOrderDto, OrderDetailDto, OrderListDto, OrderTrackingDto, CancelOrderDto
  Payment/    ← PaymentIntentDto, ConfirmPaymentDto, PaymentStatusDto
  Review/     ← ReviewDto, CreateReviewDto, ReviewSummaryDto
  Offer/      ← OfferDto, CreateOfferDto, CouponValidationDto
  Notification/ ← NotificationDto
  Support/    ← SupportTicketDto, CreateTicketDto, SupportMessageDto
  Admin/      ← DashboardStatsDto, AdminUserDto, RevenueReportDto
  Agent/      ← AgentProfileDto, AgentOrderDto, AgentEarningsDto
  Search/     ← HomeFeedDto, SearchResultDto, SuggestionDto
  

5.2  ApiResponse and PagedResult — Must Be Exactly This:
  
// FoodieApp.Application/DTOs/Common/ApiResponse.cs
namespace FoodieApp.Application.DTOs.Common
{
    public class ApiResponse<T>
    {
        public bool Success       { get; set; }
        public string Message     { get; set; } = string.Empty;
        public T? Data            { get; set; }
        public List<string> Errors { get; set; } = new();
        public int StatusCode     { get; set; }
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
 
        public static ApiResponse<T> Ok(T data, string message = "Success")
            => new() { Success=true, Message=message, Data=data, StatusCode=200 };
 
        public static ApiResponse<T> Fail(string message, int code=400, List<string>? errors=null)
            => new() { Success=false, Message=message, StatusCode=code, Errors=errors??new() };
    }
}
  

  
// FoodieApp.Application/DTOs/Common/PagedResult.cs
namespace FoodieApp.Application.DTOs.Common
{
    public class PagedResult<T>
    {
        public IEnumerable<T> Items { get; set; } = new List<T>();
        public int TotalCount  { get; set; }
        public int PageNumber  { get; set; }
        public int PageSize    { get; set; }
        public int TotalPages  => (int)Math.Ceiling(TotalCount / (double)PageSize);
        public bool HasNextPage     => PageNumber < TotalPages;
        public bool HasPreviousPage => PageNumber > 1;
    }
}
  

5.3  Create All Service Interfaces in FoodieApp.Core/Interfaces/Services/
Create one interface per service. Every method must be declared. No implementations yet.

Interface
Key Methods
IAuthService
RegisterAsync, LoginAsync, GoogleLoginAsync, RefreshTokenAsync, LogoutAsync, ChangePasswordAsync, ForgotPasswordAsync, ResetPasswordAsync, SendPhoneOtpAsync, VerifyPhoneOtpAsync, VerifyEmailAsync
IUserService
GetProfileAsync, UpdateProfileAsync, UploadProfileImageAsync, GetWalletAsync, GetWalletTransactionsAsync, GetAddressesAsync, AddAddressAsync, UpdateAddressAsync, DeleteAddressAsync, GetNotificationsAsync, MarkNotificationReadAsync
IRestaurantService
GetRestaurantsAsync, GetNearbyAsync, GetFeaturedAsync, GetTopRatedAsync, GetBySlugAsync, CreateAsync, UpdateAsync, ToggleAcceptingOrdersAsync, AddFavoriteAsync, RemoveFavoriteAsync, GetFavoritesAsync, ApproveAsync, RejectAsync
IMenuService
GetFullMenuAsync, GetItemByIdAsync, SearchMenuItemsAsync, AddCategoryAsync, UpdateCategoryAsync, DeleteCategoryAsync, AddItemAsync, UpdateItemAsync, ToggleItemAvailabilityAsync, AddCustomizationAsync, AddAddOnAsync
ICartService
GetCartAsync, AddToCartAsync, UpdateCartItemAsync, RemoveItemAsync, ClearCartAsync, GetItemCountAsync, ApplyCouponAsync, RemoveCouponAsync, ReplaceCartAsync
IOrderService
PlaceOrderAsync, GetMyOrdersAsync, GetActiveOrderAsync, GetOrderByIdAsync, CancelOrderAsync, ReorderAsync, RateOrderAsync, AcceptOrderAsync, RejectOrderAsync, MarkPreparingAsync, MarkReadyAsync
IPaymentService
CreatePaymentIntentAsync, ConfirmPaymentAsync, HandleWebhookAsync, RefundPaymentAsync, WalletTopupAsync, GetPaymentStatusAsync
IReviewService
CreateReviewAsync, GetRestaurantReviewsAsync, GetReviewSummaryAsync, VoteReviewAsync, ReplyToReviewAsync, DeleteReviewAsync, GetMyReviewsAsync
IOfferService
ValidateCouponAsync, GetAvailableOffersAsync, GetPlatformOffersAsync, CreateOfferAsync, UpdateOfferAsync, DeleteOfferAsync, GetBestOfferAsync
ISearchService
GlobalSearchAsync, GetAutoSuggestionsAsync, GetTrendingSearchesAsync, GetHomeFeedAsync, GetRecentSearchesAsync, GetPersonalizedRecommendationsAsync
IDeliveryAgentService
RegisterAsync, GetProfileAsync, ToggleOnlineAsync, UpdateLocationAsync, GetAvailableOrdersAsync, AcceptOrderAsync, UpdateDeliveryStatusAs
