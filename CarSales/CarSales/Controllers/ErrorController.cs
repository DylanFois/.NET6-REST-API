using Microsoft.AspNetCore.Mvc;

public class ErrorController : ControllerBase{
    [Route("/error")]
    public IActionResult Error(){
        return Problem();
    }
}