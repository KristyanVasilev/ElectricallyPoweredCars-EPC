using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EPC.Infrastructure.Data.DataConstants;

namespace EPC.Core.Models.Cars
{
    public class AddCarFormModel
    {
        [Required]
        [StringLength(CarBrandMaxLenght, MinimumLength = CarBrandMinLenght)]
        public string Brand { get; init; }

        [Required]
        [MinLength(CarModelMinLenght)]
        [StringLength(CarModelMaxLenght, MinimumLength = CarModelMinLenght)]
        public string Model { get; init; }

        [Required]
        [MinLength(CarDescriptionMinLenght)]
        [StringLength(CarDescriptionMaxLenght, MinimumLength = CarDescriptionMinLenght)]
        public string Description { get; init; }

        [Range(CarYearMinValue, CarYearMaxValue)]
        public int Year { get; init; }

        [Display(Name = "Image Url")]
        [Required]
        [Url]
        public string ImageUrl { get; init; }

        [Display(Name = "Category number")]
        public int CategoryId { get; init; }

    }
}
