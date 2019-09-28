using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST_PROJECT
{
    class CableBill
    {
        private int rentalFee;
        public int RentalFee
        {
            get
            {
                return rentalFee;
            }

        }
        public CableBill(int rentalFee)
        {
            this.rentalFee = rentalFee;
            discount = false;
        }

        private int payPerViewDiscount;

        private bool discount;
        public bool Discount
        {
            set
            {
                discount = value;
                if (discount)
                {
                    payPerViewDiscount = 2;
                }
                else
                {
                    payPerViewDiscount = 0;
                }

            }
        }

        public int CalculateAmount(int payPerViewMoviesOrder)
        {
            return (rentalFee - payPerViewDiscount) * payPerViewMoviesOrder;
        }
    }
}
