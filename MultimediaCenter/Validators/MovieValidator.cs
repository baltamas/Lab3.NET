using FluentValidation;
using MultimediaCenter.Models;
using MultimediaCenter.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultimediaCenter.Validators
{
    public class MovieValidator : AbstractValidator<MovieViewModel>
    {
        public MovieValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("The movie title is mandatory");
            RuleFor(x => x.Description).MinimumLength(10).WithMessage("Please enter a description, at least 10 characters");
            RuleFor(x => x.Director).NotEmpty().WithMessage("The movie's director is mandatory");
            RuleFor(x => x.Genre).NotEmpty().WithMessage("The movie's Genre is mandatory");
            RuleFor(x => x.Rating).InclusiveBetween(1, 10).WithMessage("The rating must be between 1 and 10");
            RuleFor(x => x.ReleaseYear).InclusiveBetween(1920, 2022);
        }
    }
}
