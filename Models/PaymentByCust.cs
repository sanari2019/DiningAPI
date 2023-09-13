using DiningVsCodeNew.Models;
using Sieve.Attributes;

namespace DiningVsCodeNew
{

    public class PaymentByCust
    {
<<<<<<< HEAD
        public string enteredBy { get; set; }
        public string custCode { get; set; }
        public float totalAmount { get; set; }
        public string EnteredbyName { get; set; }
        public bool Freeze { get; set; }
=======
        [Sieve(CanSort = true, CanFilter =true)]
        public string enteredBy { get; set; }

        [Sieve(CanSort = true, CanFilter = true)]
        public string custCode { get; set; }
        public float totalAmount { get; set; }
>>>>>>> d1d611de4491d09b3979748e59a366da524225ce
    }

}