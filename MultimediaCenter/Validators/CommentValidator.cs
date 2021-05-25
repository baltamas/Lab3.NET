using FluentValidation;
using MultimediaCenter.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultimediaCenter.Validators
{
    public class CommentValidator : AbstractValidator<CommentViewModel>
    {
        public CommentValidator()
        {

            RuleFor(x => x.Content).NotEmpty().WithMessage("You must add content to your comment");
            RuleFor(x => x.Stars).InclusiveBetween(1, 5).WithMessage("The stars must be between 1 and 5");
            RuleFor(x => x.DateTime).NotEmpty().WithMessage("You must and date and time");

        }
    }
}
