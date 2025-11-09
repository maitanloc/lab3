namespace lab3.Models
{
    public class TestCustomer
    {
        private readonly List<Customer> _list;

        public TestCustomer()
        {
            _list = new List<Customer>()
            {
                new Customer { Id = 1, Subname = "Thiết kế website", Image = "/images/thietkewebsite.png" },
                new Customer { Id = 2, Subname = "Lập trình máy tính", Image = "/images/laptrinhmaytinh.png" },
                new Customer { Id = 3, Subname = "Thiết kế đồ họa", Image = "/images/tkdh.jpg" },
                new Customer { Id = 4, Subname = "CNTT - Ứng dụng phần mềm", Image = "/images/udpm.png" }
            };
        }

        public List<Customer> GetAll() => _list;

        public Customer? GetById(int id) => _list.FirstOrDefault(x => x.Id == id);
    }
}

