// See https://aka.ms/new-console-template for more information
using _0047.SeperateChainingHashWithLinkedList;

int id, choice, size;
String name;
Console.Write("Enter the initial size of the table: ");
size = Convert.ToInt32(Console.ReadLine());
HashTable hashTable = new HashTable(size);

while (true)
{
    Console.WriteLine("1. Insert a record");
    Console.WriteLine("2. Search a record");
    Console.WriteLine("3. Delete a record");
    Console.WriteLine("4. Display table");
    Console.WriteLine("5. Exit");
    Console.Write("Enter your choice: ");
    choice = Convert.ToInt32(Console.ReadLine());
    if (choice == 5)
        break;

    switch (choice)
    {
        case 1:
            Console.Write("Enter student id: ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter student name: ");
            name = Console.ReadLine();

            KeyValueRecord newRecord = new KeyValueRecord(id, name);
            hashTable.Insert(newRecord);
            break;
        case 2:
            Console.Write("Enter a key to be searched: ");
            id = Convert.ToInt32(Console.ReadLine());
            newRecord = hashTable.Search(id);

            if (newRecord == null)
                Console.WriteLine("key not found");
            else
                Console.WriteLine(newRecord.toString());
            break;
        case 3:
            Console.Write("Enter a key to be deleted: ");
            id = Convert.ToInt32(Console.ReadLine());
            hashTable.Delete(id);
            break;
        case 4:
            hashTable.DisplayTable();
            break;
    }
}

