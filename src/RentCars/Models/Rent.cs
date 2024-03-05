using RentCars.Types;

namespace RentCars.Models;

public class Rent
{
    public Vehicle Vehicle { get; set; }
    public Person Person { get; set; }
    public int DaysRented { get; set; }
    public double Price { get; set; }
    public RentStatus Status { get; set; }
    public Rent(Vehicle vehicle, Person person, int daysRented)
    {
        Vehicle = vehicle;
        Person = person;
        DaysRented = daysRented;
        Status = RentStatus.Confirmed;
        Price =  daysRented * vehicle.PricePerDay;
        if (person is LegalPerson) Price *= 0.9;

        Vehicle.IsRented = true;
        Person.Debit = Price;
    }

    //11 - Implemente os métodos de `cancelar` e `finalizar` um aluguel

//     O que será testado:

// O método Rent.Cancel() deve cancelar um aluguel

// O Status deve ser alterado para RentStatus.Cancelled
// O método Rent.Finish() deve finalizar um aluguel

// O Status deve ser alterado para RentStatus.Finished
    public void Cancel()
    {
        Status = RentStatus.Canceled;
        Vehicle.IsRented = false;
        Person.Debit = 0;
    }

    //11 - Implemente os métodos de `cancelar` e `finalizar` um aluguel
    public void Finish()
    {
        Status = RentStatus.Finished;
        Vehicle.IsRented = false;
    }
}