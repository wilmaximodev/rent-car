using RentCars.Types;

namespace RentCars.Models;

// A classe deve ter as seguintes propriedades:
// SeatHeight que deve ser do tipo double;
// FrontBrake que deve ser do tipo BrakeType;
// RearBrake que deve ser do tipo BrakeType;
public class Motorcycle : Vehicle
{
    public double SeatHeight { get; set; }
    public BrakeType FrontBrake { get; set; }
    public BrakeType RearBrake { get; set; }
}