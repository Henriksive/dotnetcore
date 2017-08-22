using System;
using System.Collections.Generic;
using System.Linq;
using dotnetcore_hoved.types;

namespace dotnetcore_hoved.services
{
    public interface IMiddagService 
    {
        Middag GetRandom();
    }
	public class MiddagService : IMiddagService
	{
        private List<Middag> middager = new List<Middag>()
        {
            new Middag("Pølse i brød"),
            new Middag("Vegetarwok"),
            new Middag("Hamburger")
        };
		public Middag GetRandom()
		{
            var randomGen = new Random();
			return middager[randomGen.Next(middager.Count())];
		}
	}
}