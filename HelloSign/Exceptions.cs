using System;

namespace HelloSign
{
    // HTTP Error Status Exceptions
    public class BadRequestException : Exception
    {
        public BadRequestException() : base() { }
        public BadRequestException(string message) : base(message) { }
    }
    public class UnauthorizedException : Exception
    {
        public UnauthorizedException() : base() { }
        public UnauthorizedException(string message) : base(message) { }
    }
    public class PaymentRequiredException : Exception
    {
        public PaymentRequiredException() : base() { }
        public PaymentRequiredException(string message) : base(message) { }
    }
    public class ForbiddenException : Exception
    {
        public ForbiddenException() : base() { }
        public ForbiddenException(string message) : base(message) { }
    }
    public class NotFoundException : Exception
    {
        public NotFoundException() : base() { }
        public NotFoundException(string message) : base(message) { }
    }
    public class MethodNotAllowedException : Exception
    {
        public MethodNotAllowedException() : base() { }
        public MethodNotAllowedException(string message) : base(message) { }
    }
    public class ConflictException : Exception
    {
        public ConflictException() : base() { }
        public ConflictException(string message) : base(message) { }
    }
    public class GoneException : Exception
    {
        public GoneException() : base() { }
        public GoneException(string message) : base(message) { }
    }
    public class UnknownException : Exception
    {
        public UnknownException() : base() { }
        public UnknownException(string message) : base(message) { }
    }
    public class ServiceUnavailableException : Exception
    {
        public ServiceUnavailableException() : base() { }
        public ServiceUnavailableException(string message) : base(message) { }
    }
}
