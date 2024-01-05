using System;

namespace Octy.Application.DTOs.Common
{
    public abstract class BaseDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
