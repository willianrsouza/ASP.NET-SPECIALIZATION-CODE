﻿
using Infrastructure.Persistence;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Commands.Projects.FinishProject
{
    public class FinishProjectCommandHandler : IRequestHandler<FinishProjectCommand, Unit>
    {

        private readonly DevFreelaDbContext _dbContext;

        public FinishProjectCommandHandler(DevFreelaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(FinishProjectCommand request, CancellationToken cancellationToken)
        {

            var project = _dbContext.Projects.SingleOrDefault(p => p.Id == request.Id);

            project.Finish();
            await _dbContext.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
