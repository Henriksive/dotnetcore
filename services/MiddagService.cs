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
            new Middag("Pølse i brød", 1),
            new Middag("Vegetarwok", 2),
            new Middag("Hamburger", 3),
            new Middag("Fiskegrateng", 3),
            new Middag("Kjøttboller og potetstappe", 2)
        };
		public Middag GetRandom()
		{
            var randomGen = new Random();
			return middager[randomGen.Next(middager.Count())];
		}
	}
}