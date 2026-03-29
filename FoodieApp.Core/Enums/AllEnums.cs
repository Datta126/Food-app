namespace FoodieApp.Core.Enums {
    public enum UserGender { Male, Female, Other, PreferNotToSay }
    public enum AddressLabel { Home, Work, Other }
    public enum OrderStatus { Pending, Confirmed, Preparing, ReadyForPickup, PickedUp, OutForDelivery, Delivered, Cancelled, Rejected }
    public enum PaymentStatus { Pending, Paid, Failed, Refunded }
    public enum PaymentMethod { CashOnDelivery, Card, UPI, NetBanking, Wallet }
    public enum SpicyLevel { NotSpicy, Mild, Medium, Hot, ExtraHot }
    public enum VehicleType { Bicycle, Motorcycle, Scooter, Car }
    public enum DiscountType { Percentage, FlatAmount }
    public enum OfferApplicability { AllUsers, NewUsersOnly, SelectedUsers }
    public enum SupportTicketStatus { Open, InProgress, Resolved, Closed }
    public enum SupportPriority { Low, Medium, High, Critical }
    public enum NotificationType { OrderUpdate, OfferAlert, AccountUpdate, General }
    public enum WalletTransactionType { Credit, Debit }
    public enum WalletTransactionSource { Refund, ReferralBonus, Cashback, AdminCredit, OrderPayment, WalletTopup }
    public enum LoyaltyTransactionType { Earned, Redeemed, Expired }
    public enum MessageSenderType { Customer, DeliveryAgent, SupportAgent, Admin, System }
    public enum AgentVerificationStatus { Pending, Verified, Rejected, Suspended }
    public enum RestaurantSortBy { Relevance, Rating, DeliveryTime, CostLowToHigh, CostHighToLow, Distance }
    public enum DayOfWeekCustom { Monday=1, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }
}