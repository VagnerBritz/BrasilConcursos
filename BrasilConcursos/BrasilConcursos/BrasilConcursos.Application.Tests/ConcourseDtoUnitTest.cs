using BrasilConcursos.Application.DTOs;
using BrasilConcursos.Domain.Entities;
using FluentAssertions;
using System;

namespace BrasilConcursos.Application.Tests
{
    public class ConcourseDtoUnitTest
    {

        [Fact(DisplayName = "Create concourse with valid state")]
        public void createConcourseWithValidParameters_ResultObjectValidState()
        {
            //Action action = () => new ConcourseDto(
            // Guid.NewGuid(),
            // "",
            // "Cesgranrio",
            // "https://www.cesgranrio.com.br/Cef",
            // DateTime.Now,
            // (DateTime.Now.AddDays(10)),
            // new List<Position>()
            // );

            //action.Should().NotThrow();
            //ConcourseDto invalid = new();

            //Action action = () => invalid.Id = Guid.Empty;
            //action.Should().NotThrow();

            //Action name = () => invalid.PublicAgency = "a";
            ConcourseDto instance = new();
            instance.PublicAgency = "abdfdf";
            instance.PublicAgency.Should().Be("abdfdf");

        }

    }
}