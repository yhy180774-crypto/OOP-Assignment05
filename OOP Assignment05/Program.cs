
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


#region Question07

/// 07) Update StandardShipment to inherit from abstract Shipment
/// and implement ITrackable and IInsurable.

//public class standardshipment : shipment, itrackable, iinsurable
//     {
//            public standardshipment(string trackingcode, string description, decimal weight, decimal deliveryfee, deliveryaddress destination) : base(trackingcode, description, weight, deliveryfee, destination)

//                      {
//         }

//     public override decimal estimatedcost
//     {
//         get
//        {
//             return deliveryfee + (weight* 5);
//        }
//    }

//     public override void printshipment()
//     {
// console.writeline("standard shipment");
// console.writeline();
// console.writeline("tracking code : " + trackingcode);
// console.writeline("description   : " + description);
// console.writeline("estimated cost: " + estimatedcost + " egp");
//     }

//         public string gettrackingstatus()
//         {
//             return $"shipment {trackingcode} is ready.";
//         }

//         public decimal calculateinsurance()
//         {
//             return estimatedcost * 0.05m;
//         }
//     }

#endregion


#region Question08

/// 08) Update ExpressShipment to implement ITrackable and IInsurable.
///
/// public class ExpressShipment : Shipment, ITrackable, IInsurable
/// {
///     public decimal ExtraFee { get; set; }
///
///     public override decimal EstimatedCost
///     {
///         get
///         {
///             return DeliveryFee + (Weight * 5) + ExtraFee;
///         }
///     }
///
///     public string GetTrackingStatus()
///     {
///         return $"Shipment {TrackingCode} is Out for Delivery.";
///     }
///
///     public decimal CalculateInsurance()
///     {
///         return EstimatedCost * 0.08m;
///     }
/// }

#endregion


#region Question09

/// 09) Update InternationalShipment to implement ITrackable and IInsurable.
///
/// public class InternationalShipment : Shipment, ITrackable, IInsurable
/// {
///     public string DestinationCountry { get; set; }
///     public decimal CustomsFee { get; set; }
///
///     public override decimal EstimatedCost
///     {
///         get
///         {
///             return DeliveryFee
///                  + (Weight * 5)
///                  + CustomsFee;
///         }
///     }
///
///     public string GetTrackingStatus()
///     {
///         return $"Shipment {TrackingCode} has been Delivered.";
///     }
///
///     public decimal CalculateInsurance()
///     {
///         return EstimatedCost * 0.12m;
///     }
/// }
///


#endregion


#region Question10

/// 10) Create DeliveryReport.
///
/// public static class DeliveryReport
/// {
///     public static void PrintShipment(ITrackable shipment)
///     {
///         Console.WriteLine(shipment.GetTrackingStatus());
///     }
///
///     public static void PrintInsurance(IInsurable shipment)
///     {
///         Console.WriteLine("Insurance Cost: "
///                           + shipment.CalculateInsurance()
///                           + " EGP");
///     }
/// }

#endregion


#region Question11

/// 11) Add PrintTrackingStatuses() to DeliveryCenter.
///
/// public void PrintTrackingStatuses()
/// {
///     foreach (Shipment shipment in shipments)
///     {
///         if (shipment != null)
///         {
///             ITrackable trackable = shipment as ITrackable;
///
///             if (trackable != null)
///             {
///                 Console.WriteLine(
///                     trackable.GetTrackingStatus());
///             }
///         }
///     }
/// }

#endregion


#region Question12

/// 12) Create all shipment objects and add them to the DeliveryCenter.
///
/// StandardShipment standardShipment =
///     new StandardShipment(
///         "SH001",
///         "Laptop",
///         3,
///         80,
///         address1);
///
/// ExpressShipment expressShipment =
///     new ExpressShipment(
///         "SH002",
///         "Mobile Phone",
///         2,
///         60,
///         address2,
///         30);
///
/// InternationalShipment internationalShipment =
///     new InternationalShipment(
///         "SH003",
///         "Television",
///         8,
///         120,
///         address3,
///         "Germany",
///         100);
///
/// center.AddShipment(standardShipment);
/// center.AddShipment(expressShipment);
/// center.AddShipment(internationalShipment);

#endregion


#region Question13

/// 13) Print the tracking status of every shipment.
///
/// center.PrintTrackingStatuses();

#endregion


#region Question14

/// 14) Store shipment objects in an ITrackable[] array
/// and print their tracking statuses.
///
/// ITrackable[] trackableShipments =
/// {
///     standardShipment,
///     expressShipment,
///     internationalShipment
/// };
///
/// foreach (ITrackable shipment in trackableShipments)
/// {
///     Console.WriteLine(shipment.GetTrackingStatus());
/// }.

#endregion


#region Question15

/// 15) Store shipment objects in an IInsurable[] array
/// and print their insurance values.
///
/// IInsurable[] insurableShipments =
/// {
///     standardShipment,
///     expressShipment,
///     internationalShipment
/// };
///
/// foreach (IInsurable shipment in insurableShipments)
/// {
///     Console.WriteLine("Insurance Cost: " + shipment.CalculateInsurance() + " EGP");
/// }

#endregion

































































