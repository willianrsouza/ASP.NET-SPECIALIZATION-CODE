﻿using MediatR;

namespace Application.Commands.Projects.Update
{
    public class UpdateProjectCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal TotalCost { get; set; }
    }
}
