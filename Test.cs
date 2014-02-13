
namespace ExserciseTwo
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;

    class Test
    {
        //adds worker to a list of workers, calling MoneyPerHour method to calculate mony per hour for that worker;
        public static void AddWorkersToList(Worker worker,List<Worker> listOfWorkers, int workHours, int weekSalary)
        {           
            worker.MoneyPerHour(workHours, weekSalary);
            listOfWorkers.Add(worker);         
        }
        static void Main()
        {
            List<Student> listOfStudents = new List<Student>() {new Student("Ivo","Vasilev",1),new Student("Petar","Petrov",3),
                                           new Student("Tzvetan","Vasilev",2),new Student("Eva","Todorova",2),new Student("Yordanka","Ivanova",3),
                                           new Student("Todor","Valchev",1),new Student("Reni","Markova",4),new Student("Tatqna","Petrova",4),
                                           new Student("Svtlin","Nakov",2),new Student("Katiq","Velikova",1)};

            //sorts students by grade
            var sortedStudentsByGrade = listOfStudents.OrderBy(st => st.Grade);

            foreach (var student in sortedStudentsByGrade)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();

            List<Worker> listOfWorkers = new List<Worker>();

            AddWorkersToList(new Worker("Ivaylo", "Vasilev"), listOfWorkers, 8, 175);
            AddWorkersToList(new Worker("Georgi", "Ivanov"), listOfWorkers, 8,650);
            AddWorkersToList(new Worker("Alex", "Veselinov"), listOfWorkers, 4, 100);
            AddWorkersToList(new Worker("Iliq", "Iliev"), listOfWorkers, 8, 200);
            AddWorkersToList(new Worker("Damqn", "Zarev"), listOfWorkers, 12, 600);
            AddWorkersToList(new Worker("Petar", "Stoqnov"), listOfWorkers, 10, 250);
            AddWorkersToList(new Worker("Axel", "Rose"), listOfWorkers, 4, 1200);
            AddWorkersToList(new Worker("Reneta", "Indjova"), listOfWorkers, 8, 100);
            AddWorkersToList(new Worker("Tashko", "Tashev"), listOfWorkers, 8, 250);
            AddWorkersToList(new Worker("Petko", "Bucharov"), listOfWorkers, 10, 350);

            //sorts workers by money per hour
            var workersSortedByMoneyPerHour = listOfWorkers.OrderByDescending(w => w.ReturnMoneyPerHour);

            foreach (var worker in workersSortedByMoneyPerHour)
            {
                Console.WriteLine(worker);
            }

            Console.WriteLine();

            Stopwatch watch = new Stopwatch();

            watch.Start();

            //merge using Concat
            var merged = listOfStudents.Concat<Human>(listOfWorkers).ToList();

            watch.Stop();

            Console.WriteLine("Time elapsed for merging: {0}", watch.Elapsed);

            Console.WriteLine();

            Stopwatch newWatch = new Stopwatch();

            newWatch.Start();

            //merge using AddRange
            var mergedTwo = new List<Human>(listOfStudents.Count + listOfWorkers.Count);

            mergedTwo.AddRange(listOfStudents);
            mergedTwo.AddRange(listOfWorkers);

            newWatch.Stop();

            Console.WriteLine();

            Console.WriteLine("Time elapsed for merging: {0}", newWatch.Elapsed);

            //As you can see the second method for merging the two lists is faster

            Console.WriteLine();

            var sortedMergedListByName = mergedTwo.OrderBy(h => h.FirstName).ThenBy(h => h.LastName);

            foreach (var human in sortedMergedListByName)
            {
                Console.WriteLine(human);
            }

            Console.WriteLine();
        }
    }
}
