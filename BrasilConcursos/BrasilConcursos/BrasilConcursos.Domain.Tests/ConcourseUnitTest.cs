using BrasilConcursos.Domain.Entities;
using FluentAssertions;
using System.ComponentModel.DataAnnotations;

namespace BrasilConcursos.Domain.Tests
{
    public class ConcourseUnitTest
    {
        public Concourse CriateInstance()
        {

                return new Concourse(
                publicAgency: "Caixa Econômica Federal",
                examinationBoard: "Cesgranrio",
                new List<Position>(),
                noticeUrl: "https://www.cesgranrio.com.br/CEF",
                registrationStartDate: DateTime.Now,
                registrationEndDate: DateTime.Now.AddDays(10)
                );
        }

        [Fact(DisplayName = "Create Concourse with valid state")]
        public void CreateConcourse_WithValidParameters_ResultNotThrow()
        {
            Action action = () => new Concourse(
                publicAgency: "Caixa Econômica Federal",
                examinationBoard: "Cesgranrio",
                new List<Position>(),
                noticeUrl: "https://www.cesgranrio.com.br/CEF",
                registrationStartDate: DateTime.Now,
                registrationEndDate: DateTime.Now.AddDays(10)
                );
            action.Should().NotThrow();
            
        }
        [Fact(DisplayName = "Create Concourse with valid state2")]
        public void CreateConcourse_WithValidParameters_ResultObjectValidState()
        {
            
            Concourse instance = CriateInstance();
            instance.Should().NotBeNull();
            instance.Should().BeAssignableTo<Concourse>();
            instance.Id.GetType().Should().Be(typeof(Guid));
            instance.PublicAgency.Should().Be(instance.PublicAgency);
            instance.ExaminationBoard.Should().Be(instance.ExaminationBoard);
            instance.NoticeUrl.Should().Be(instance.NoticeUrl);
            instance.RegistrationStartDate.Should().Be(instance.RegistrationStartDate);
            instance.RegistrationEndDate.Should().Be(instance.RegistrationEndDate);
            instance.Positions.Should().BeAssignableTo<List<Position>>();
        }
        [Fact(DisplayName = "Try create Concourse with invalid data")]
        public void CreateConcourse_WithInvalidParameters_ResultThrow()
        {
            Concourse instance = CriateInstance();
            instance.PublicAgency = "";
            // Act
            var validationResults = new List<ValidationResult>();
            var isValid = Validator.TryValidateObject(instance, new ValidationContext(instance), validationResults, true);

            // Assert
            isValid.Should().BeFalse(); // A validação deve falhar

            validationResults.Should().ContainSingle(vr =>
                vr.MemberNames.Contains("PublicAgency") && vr.ErrorMessage == "The name is Required.");
            validationResults.Should().ContainSingle(vr =>
                vr.MemberNames.Contains("PublicAgency") && vr.ErrorMessage == "Mínimo de 3 letras");

        }
    }
}