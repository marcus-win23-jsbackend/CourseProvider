﻿using CourseProvider.Infrastructure.Models;
using CourseProvider.Infrastructure.Services;
using Microsoft.AspNetCore.Cors.Infrastructure;

namespace CourseProvider.Infrastructure.GraphQL.Queries;

public class CourseQuery(ICourseService courseService)
{
    private readonly ICourseService _courseService = courseService;

    [GraphQLName("getAllCourses")]
    public async Task<IEnumerable<Course>> GetCoursesAsync()
    {
        return await _courseService.GetCoursesAsync();
    }

    [GraphQLName("getCourseById")]
    public async Task<Course> GetCourseByIdAsync(string id)
    {
        return await _courseService.GetCourseByIdAsync(id);
    }
}
