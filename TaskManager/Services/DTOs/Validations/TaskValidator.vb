Imports FluentValidation

Namespace TaskManager.Services.DTOs.Validations
    Public Class TaskValidator
        Inherits AbstractValidator(Of TaskDTO)

        Public Sub New()
            RuleFor(Function(x) x.Title).Matches("^[a-zA-Z0-9\s]*$").WithMessage("O título deve conter apenas letras, números e espaços.").When(Function(x) Not String.IsNullOrEmpty(x.Title))
            RuleFor(Function(x) x.DueDate).NotEmpty().WithMessage("DueDate is required")
            RuleFor(Function(x) x.UserId).NotEmpty().WithMessage("UserId is required")
        End Sub

    End Class

End Namespace

