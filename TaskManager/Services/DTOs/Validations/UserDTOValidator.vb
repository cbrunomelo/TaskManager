Imports FluentValidation
Imports TaskManager.TaskManager.Services
Imports TaskManager.TaskManager.Services.Contracts
Imports TaskManager.TaskManager.Services.DTOs

Public Class UserDTOValidator
    Inherits AbstractValidator(Of UserDTO)
    Private _userService As IUserService

    Public Sub New(userservice As IUserService)
        _userService = userservice
        'for Name
        RuleFor(Function(x) x.Name).NotEmpty().WithMessage("O nome é obrigatório.").When(Function(x) x.UseCase = EUseCase.NovoRegistro)

        RuleFor(Function(x) x.Name).Matches("^[a-zA-Z0-9\s]*$").WithMessage("O nome deve conter apenas letras, números e espaços.") _
            .When(Function(x) Not String.IsNullOrEmpty(x.Name))

        RuleFor(Function(x) x.Name).Length(3, 50).WithMessage("O nome deve conter entre 3 e 50 caracteres.") _
            .When(Function(x) Not String.IsNullOrEmpty(x.Name))

        'if the name alrdy in use
        RuleFor(Function(x) x.Name).Must(Function(x) Not _userService.IsNameInUse(x)).WithMessage("O nome já está em uso.").When(Function(x) Not String.IsNullOrEmpty(x.Name))


        'for Password
        RuleFor(Function(x) x.Password).Matches("^[a-zA-Z0-9\s]*$").WithMessage("A senha deve conter apenas letras, números e espaços.") _
            .When(Function(x) Not String.IsNullOrEmpty(x.Password))

        RuleFor(Function(x) x.Password).NotEmpty().WithMessage("A senha é obrigatória.") _
            .When(Function(x) x.UseCase = EUseCase.NovoRegistro Or (x.UseCase = EUseCase.EditarRegistro And Not String.IsNullOrEmpty(x.Password)))

        'for RepeatPassword

        RuleFor(Function(x) x.RepeatPassword).Equal(Function(x) x.Password).WithMessage("As senhas não conferem.") _
        .When(Function(x) x.UseCase = EUseCase.NovoRegistro Or (x.UseCase = EUseCase.EditarRegistro And Not String.IsNullOrEmpty(x.Password)))

    End Sub

End Class
