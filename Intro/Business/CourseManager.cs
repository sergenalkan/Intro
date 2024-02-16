﻿using Intro.DataAccess.Abstracts;
using Intro.DataAccess.Concretes;
using Intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.Business;

public class CourseManager
{
    //dependency injection
    //lousely coupled : şablona bağlılık
    private readonly ICourseDal _courseDal;

    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;           
    }

    public List<Course> GetAll()
    {
        //veri kaynağından çekilir
        //business rules
       
        return _courseDal.GetAll();
    }
}