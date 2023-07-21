﻿using Pets.Application.Output.DTOs;
using Pets.Application.Output.Requests.Contracts;
using Pets.Application.Output.Results;

namespace Pets.Application.Output.Requests.PetsRequests
{
    public class TutorPetsRequest : IRequestBase
    {
        public Result? Result { get; set; }
        public TutorDTO Tutor { get; set; }
        public ICollection<PetDTO>? Pets { get; set; }

    }
}
