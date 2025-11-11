
// Amir Moeini Rad
// April 26, 2025

// Main Concept: DNS Lookup

// Namespace: System.Net
// Classes: Dns, IPHostEntry, IPAddress

// How does the DNS class obtain the IP address of a domain?
// It asks the DNS server configured on the local machine to resolve the domain name to its corresponding IP address.

using System.Net;

namespace DNS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------");
            Console.WriteLine("DNS Lookup Tool");
            Console.WriteLine("---------------\n");


            Console.Write("Enter a domain name, like www.example.com: ");
            string? domain = Console.ReadLine();

            // The 'DNS' class provides simple domain name resolution functionality.
            // The 'GetHostEntry' method retrieves the DNS information for the specified domain.
            // The DNS info is returned as an 'IPHostEntry' object,
            // which contains a list of IP addresses associated with the domain.
            // '??' is the null-coalescing operator, which provides a default value if 'domain' is null.
            IPHostEntry host = Dns.GetHostEntry(domain ?? "www.google.com");

            // The 'AddressList' property of the 'IPHostEntry' object contains an array of 'IPAddress' objects.
            // The 'IPAddress' class represents an IP address.
            foreach (IPAddress ip in host.AddressList)
            {
                Console.WriteLine($"IP Address: {ip}");
            }


            Console.WriteLine("\nDone.");
        }
    }
}
