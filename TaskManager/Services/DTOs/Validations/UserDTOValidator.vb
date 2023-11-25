Imports FluentValidation

Public Class UserDTOValidator
    Inherits AbstractValidator(Of UserDTO)

    Public Sub New()
        'for Name
        RuleFor(Function(x) x.Name).NotEmpty().WithMessage("O nome é obrigatório.")
        RuleFor(Function(x) x.Name).Matches("^[a-zA-Z0-9\s]*$").WithMessage("O nome deve conter apenas letras, números e espaços.").When(Function(x) Not String.IsNullOrEmpty(x.Name))
        RuleFor(Function(x) x.Name).Length(3, 50).WithMessage("O nome deve conter entre 3 e 50 caracteres.").When(Function(x) Not String.IsNullOrEmpty(x.Name))


        'for Password
        RuleFor(Function(x) x.Password).Matches("^[a-zA-Z0-9\s]*$").WithMessage("A senha deve conter apenas letras, números e espaços.").When(Function(x) Not String.IsNullOrEmpty(x.Password))
        RuleFor(Function(x) x.Password).NotEmpty().WithMessage("A senha é obrigatória.")



    End Sub

End Class
