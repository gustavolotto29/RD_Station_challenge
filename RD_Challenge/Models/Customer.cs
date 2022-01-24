using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RD_Challenge.Models
{
    public class Customer
    {
        public Customer(int id, int score)
        {
            this.Id = id;
            this.Score = score;
        }

        public int Id { get; set; }
        public int Score { get; set; }
    }
}
