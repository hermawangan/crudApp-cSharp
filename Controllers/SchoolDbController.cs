using Microsoft.AspNetCore.Mvc;

namespace SchooldDatabase.controller
{
    [Route("api/[controller]")]
    [ApiController]

    public class SchoolController : ControllerBase
    {
        [HttpGet]

        public IActionResult Get()
        {
            return Ok(StudentList.Student);
        }

        [HttpPost]
        public IActionResult Post(SchoolDbPost model)
        {
            StudentList.Student.Add(new SchoolDb()
            {
                id = Guid.NewGuid(),
                firstName = model.firstName,
                lastName = model.lastName,
                age = model.age,
                birthDate = model.birthDate,
                religion = model.religion
            });
            return StatusCode(200);
        }

        [HttpPut("{id}")]
        public IActionResult Put(SchoolDbPut model)
        {
            SchoolDb students = StudentList.Student.Where(x => x.id == model.id).FirstOrDefault();
            students.firstName = model.firstName;
            students.lastName = model.lastName;
            students.birthDate = model.birthDate;
            students.age = model.age;
            students.religion = model.religion;
            return StatusCode(200);
        }

        

        [HttpDelete("{id}")]
        public IActionResult Delete(SchoolDbDelete model)
        {
            SchoolDb students = StudentList.Student.Where(x => x.id == model.id).FirstOrDefault();
            StudentList.Student.Remove(students);
            return StatusCode(200);
        }
    }
}
