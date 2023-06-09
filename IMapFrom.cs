﻿using AutoMapper;

namespace Cinema.Services.Mapper;

public interface IMapFrom<T>
{
    void MappingFrom(Profile profile)
    {
        profile.CreateMap(typeof(T), GetType());
    }
}