﻿using CleanArchitecture.Core.Dtos;
using CleanArchitecture.Core.Interfaces.Common;
using Core.Models;

namespace Core.Dtos;

public class CowDto:BaseDto,IMapFrom<Cow>
{
    public string Color { get; set; }
}