using Microsoft.AspNetCore.Mvc;

namespace JACMS.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PostController : ControllerBase
    {
        private readonly ILogger<PostController> _logger;

        public PostController(ILogger<PostController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// An endpoint handling post creation.
        /// </summary>
        /// <param name="page">A post creation request.</param>
        /// <returns>The created post.</returns>
        [HttpPut]
        public IActionResult Put(dynamic post)
        {
            return Ok();
        }

        /// <summary>
        /// An endpoint for getting a post by Id.
        /// </summary>
        /// <param name="id">The post's ID as stored in the DB.</param>
        /// <returns>The post with all of its sections</returns>
        [HttpGet]
        public IActionResult Get(int id)
        {
            return Ok();
        }

        /// <summary>
        /// An endpoint for getting a post by its slug.
        /// </summary>
        /// <param name="slug">The post's slug as stored in the db</param>
        /// <returns>The post with all of its sections</returns>
        [HttpGet]
        public IActionResult Get(string slug)
        {
            return Ok();
        }

        /// <summary>
        /// An endpoint for updating a post.
        /// </summary>
        /// <param name="page">The post to update</param>
        /// <returns>The results of updating the post's data.</returns>
        [HttpPost]
        public IActionResult Post(dynamic post)
        {
            return Ok();
        }


        /// <summary>
        /// An endpoint for deleteing a post by its Id.
        /// </summary>
        /// <param name="id">The post's id as stored in the DB.</param>
        /// <returns>An action result that contians results of the DB action.</returns>
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            return Ok();
        }
    }
}
