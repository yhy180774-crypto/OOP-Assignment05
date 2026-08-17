
#region Question01

/// 01) Abstraction
///
/// a) What is Abstraction in Object-Oriented Programming?
///
/// Answer:
/// Abstraction is the process of hiding unnecessary implementation details
/// and showing only the important features of an object.
///
/// b) Why is abstraction considered one of the four pillars of OOP?
///
/// Answer:
/// Abstraction is one of the four pillars of OOP because it helps hide
/// unnecessary implementation details and allows the programmer to focus
/// on what an object does instead of how it does it.
///
/// The four pillars of OOP are:
/// Encapsulation, Inheritance, Polymorphism, and Abstraction.

#endregion


#region Question02

/// 02) Abstract Classes vs. Interfaces
///
/// a) What is the difference between an Abstract Class and an Interface?
///
/// Answer:
/// An abstract class can contain fields, properties, constructors,
/// normal methods, and abstract methods.
///
/// An interface mainly defines a contract that specifies what members
/// a class must implement.
///
/// An abstract class is used when classes share common data and behavior,
/// while an interface is used to define common capabilities or behaviors.
///
/// b) When would you choose an Interface instead of an Abstract Class?
///
/// Answer:
/// We choose an Interface when different classes need to follow the same
/// contract or provide the same behavior, even if they do not belong
/// to the same inheritance hierarchy.
///

#endregion


#region Question03

/// 03) Convert Shipment into an Abstract Class.
///
/// public abstract class Shipment
/// {
///     private string trackingCode;
///     private string description;
///     private decimal weight;
///     private decimal deliveryFee;
///
///     public string TrackingCode
///     {
///         get { return trackingCode; }
///     }
///
///     public string Description
///     {
///         get { return description; }
///         set
///         {
///             if (!string.IsNullOrWhiteSpace(value))
///                 description = value;
///         }
///     }
///
///     public decimal Weight
///     {
///         get { return weight; }
///         set
///         {
///             if (value > 0)
///                 weight = value;
///         }
///     }
///
///     public decimal DeliveryFee
///     {
///         get { return deliveryFee; }
///         private set
///         {
///             if (value > 0)
///                 deliveryFee = value;
///         }
///     }
///
///     public DeliveryAddress Destination { get; set; }
/// }

#endregion


#region Question04

/// 04) Add Abstract EstimatedCost and PrintShipment() members.
///
/// public abstract decimal EstimatedCost
/// {
///     get;
/// }
///
/// public abstract void PrintShipment();
///

#endregion


#region Question05

/// 05) Create ITrackable interface.
///
/// public interface ITrackable
/// {
///     string GetTrackingStatus();
/// }

#endregion


#region Question06

/// 06) Create IInsurable interface.
///
/// public interface IInsurable
/// {
///     decimal CalculateInsurance();
/// }
///

#endregion




























































































