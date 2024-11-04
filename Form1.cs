using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Quanlykhachhangvahoadon
{
    public partial class Form1 : Form
    {
        private List<Customer> customers = new List<Customer>();
        private List<Service> services = new List<Service>();
        private List<Service> invoiceServices = new List<Service>();
        private int customerCounter = 1;
        private int invoiceCounter = 1;
        public Form1()
        {
            InitializeComponent();
            InitializeData();
            LoadCustomerData();
            LoadServiceData();
        }
        private void InitializeData()
        {
            services.Add(new Service(1, "Internet", 50.0m));
            services.Add(new Service(2, "Hosting", 75.0m));
            services.Add(new Service(3, "Consulting", 100.0m));
        }

        private void LoadCustomerData()
        {
            dataGridViewCustomers.DataSource = null;
            dataGridViewCustomers.DataSource = customers;
        }

        private void LoadServiceData()
        {
            dataGridViewServices.DataSource = null;
            dataGridViewServices.DataSource = services;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridViewServices.SelectedRows.Count > 0)
            {
                int index = dataGridViewServices.SelectedRows[0].Index;
                var selectedService = services[index];
                invoiceServices.Add(selectedService);

                dataGridViewInvoice.DataSource = null;
                dataGridViewInvoice.DataSource = invoiceServices;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (dataGridViewCustomers.SelectedRows.Count > 0)
            {
                int customerIndex = dataGridViewCustomers.SelectedRows[0].Index;
                var customer = customers[customerIndex];

                var invoice = new Invoice(invoiceCounter++, customer, new List<Service>(invoiceServices));
                MessageBox.Show($"Invoice Created for {customer.Name}\nTotal Amount: {invoice.TotalAmount:C}", "Invoice");

                invoiceServices.Clear();
                dataGridViewInvoice.DataSource = null;
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            // Giả sử form để thêm thông tin có các TextBox txtName, txtPhone, txtAddress
            var name = txtName.Text;
            var phone = txtPhone.Text;
            var address = txtAddress.Text;

            var customer = new Customer(customerCounter++, name, phone, address);
            customers.Add(customer);
            LoadCustomerData();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            if (dataGridViewCustomers.SelectedRows.Count > 0)
            {
                int index = dataGridViewCustomers.SelectedRows[0].Index;
                var selectedCustomer = customers[index];

                selectedCustomer.Name = txtName.Text;
                selectedCustomer.PhoneNumber = txtPhone.Text;
                selectedCustomer.Address = txtAddress.Text;

                LoadCustomerData();
            }
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (dataGridViewCustomers.SelectedRows.Count > 0)
            {
                int index = dataGridViewCustomers.SelectedRows[0].Index;
                customers.RemoveAt(index);
                LoadCustomerData();
            }
        }
        public class Customer
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string PhoneNumber { get; set; }
            public string Address { get; set; }

            public Customer(int id, string name, string phoneNumber, string address)
            {
                Id = id;
                Name = name;
                PhoneNumber = phoneNumber;
                Address = address;
            }
        }
        public class Service
        {
            public int ServiceId { get; set; }
            public string ServiceName { get; set; }
            public decimal Price { get; set; }

            public Service(int serviceId, string serviceName, decimal price)
            {
                ServiceId = serviceId;
                ServiceName = serviceName;
                Price = price;
            }
        }
        public class Invoice
        {
            public int InvoiceId { get; set; }
            public Customer Customer { get; set; }
            public List<Service> Services { get; set; }
            public decimal TotalAmount => Services.Sum(s => s.Price);

            public Invoice(int invoiceId, Customer customer, List<Service> services)
            {
                InvoiceId = invoiceId;
                Customer = customer;
                Services = services;
            }
        }

        private void dataGridViewServices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
