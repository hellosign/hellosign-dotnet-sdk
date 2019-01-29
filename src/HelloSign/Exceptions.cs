using System;

namespace HelloSign
{
    public class ErrorException : Exception
    {
        public string ErrorName { get; protected set; }
        public ErrorException() : base() { }
        public ErrorException(string message) : base(message) { }
        public ErrorException(string message, string name) : base(message)
        {
            ErrorName = name;
        }
    }
    
    // Event Exceptions
    public class EventHashException : Exception
    {
        public string EventBody { get; protected set; }
        public EventHashException(string message, string eventBody) : base(message)
        {
            EventBody = eventBody;
        }
    }

    // HTTP Error Status Exceptions
    public class BadRequestException : ErrorException
    {
        public BadRequestException() : base() { }
        public BadRequestException(string message) : base(message) { }
        public BadRequestException(string message, string name) : base(message, name) { }
    }
    public class UnauthorizedException : ErrorException
    {
        public UnauthorizedException() : base() { }
        public UnauthorizedException(string message) : base(message) { }
        public UnauthorizedException(string message, string name) : base(message, name) { }
    }
    public class PaymentRequiredException : ErrorException
    {
        public PaymentRequiredException() : base() { }
        public PaymentRequiredException(string message) : base(message) { }
        public PaymentRequiredException(string message, string name) : base(message, name) { }
    }
    public class ForbiddenException : ErrorException
    {
        public ForbiddenException() : base() { }
        public ForbiddenException(string message) : base(message) { }
        public ForbiddenException(string message, string name) : base(message, name) { }
    }
    public class NotFoundException : ErrorException
    {
        public NotFoundException() : base() { }
        public NotFoundException(string message) : base(message) { }
        public NotFoundException(string message, string name) : base(message, name) { }
    }
    public class MethodNotAllowedException : ErrorException
    {
        public MethodNotAllowedException() : base() { }
        public MethodNotAllowedException(string message) : base(message) { }
        public MethodNotAllowedException(string message, string name) : base(message, name) { }
    }
    public class ConflictException : ErrorException
    {
        public ConflictException() : base() { }
        public ConflictException(string message) : base(message) { }
        public ConflictException(string message, string name) : base(message, name) { }
    }
    public class GoneException : ErrorException
    {
        public GoneException() : base() { }
        public GoneException(string message) : base(message) { }
        public GoneException(string message, string name) : base(message, name) { }
    }
    public class UnknownException : ErrorException
    {
        public UnknownException() : base() { }
        public UnknownException(string message) : base(message) { }
        public UnknownException(string message, string name) : base(message, name) { }
    }
    public class ServiceUnavailableException : ErrorException
    {
        public ServiceUnavailableException() : base() { }
        public ServiceUnavailableException(string message) : base(message) { }
        public ServiceUnavailableException(string message, string name) : base(message, name) { }
    }
    public class ExceededRateLimitException : ErrorException
    {
        public ExceededRateLimitException() : base() { }
        public ExceededRateLimitException(string message) : base(message) { }
        public ExceededRateLimitException(string message, string name) : base(message, name) { }
    }
}
