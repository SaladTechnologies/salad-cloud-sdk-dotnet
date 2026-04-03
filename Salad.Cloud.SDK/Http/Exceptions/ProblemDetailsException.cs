using Salad.Cloud.SDK.Models;

namespace Salad.Cloud.SDK.Http.Exceptions;

public class ProblemDetailsException : ApiException
{
    /// <summary>The error response associated with this exception.</summary>
    public ProblemDetails ProblemDetails { get; }

    /// <summary>
    /// Initializes a new instance of the ProblemDetailsException class with an inner exception.
    /// </summary>
    /// <param name="problemDetails">The ProblemDetails associated with this exception.</param>
    /// <param name="responseMessage">The HTTP response message.</param>
    public ProblemDetailsException(
        ProblemDetails problemDetails,
        HttpResponseMessage responseMessage
    )
        : base(responseMessage)
    {
        ProblemDetails = problemDetails;
    }
}
