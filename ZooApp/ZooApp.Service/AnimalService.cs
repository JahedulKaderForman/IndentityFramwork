using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooApp.Models;
using ZooApp.ViewModels;


namespace ZooApp.Service
{
    public class AnimalService
    {
        public List<ViewAnimal> GetAnimals()
        {
            ZooContext db=new ZooContext();
            db.Animals.ToList();
            List<Animal> animals = db.Animals.ToList();

            List<ViewAnimal> viewanimal = new List<ViewAnimal>();

            foreach (Animal animal in animals)
            {
                ViewAnimal viewAnimal = new ViewAnimal()
                {

                    Id = animal.Id,
                    Name = animal.Name,
                    Quantity = animal.Quantity,
                    Origin = animal.Origin,
                    Food = animal.Food

                };
                viewanimal.Add(viewAnimal);
                
            }

            return viewanimal;


        }
    }
}
