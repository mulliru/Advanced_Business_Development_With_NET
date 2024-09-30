// See https://aka.ms/new-console-template for more information
// Create a data source by using a collection initializer.

using MyNamespace;

IEnumerable<Student> students =
[
    new Student(First: "Svetlana", Last: "Omelchenko", Id: 111, Scores: [97, 92, 81, 60]),
    new Student(First: "Claire",   Last: "O'Donnell",  Id: 112, Scores: [75, 84, 91, 39]),
    new Student(First: "Sven",     Last: "Mortensen",  Id: 113, Scores: [88, 94, 65, 91]),
    new Student(First: "Cesar",    Last: "Garcia",     Id: 114, Scores: [97, 89, 85, 82]),
    new Student(First: "Debra",    Last: "Garcia",     Id: 115, Scores: [35, 72, 91, 70]),
    new Student(First: "Fadi",     Last: "Fakhouri",   Id: 116, Scores: [99, 86, 90, 94]),
    new Student(First: "Hanying",  Last: "Feng",       Id: 117, Scores: [93, 92, 80, 87]),
    new Student(First: "Hugo",     Last: "Garcia",     Id: 118, Scores: [92, 90, 83, 78]),

    new Student("Lance",   "Tucker",      119, [68, 79, 88, 92]),
    new Student("Terry",   "Adams",       120, [99, 82, 81, 79]),
    new Student("Eugene",  "Zabokritski", 121, [96, 85, 91, 60]),
    new Student("Michael", "Tucker",      122, [94, 92, 91, 91])
];

var queryHighScoresFirstTest=
    from student in students
    where student.Scores[0] > 90 
          && student.Scores[3] < 80
    select student;

queryHighScoresFirstTest.ToList()
    .ForEach(student => Console.WriteLine($"{student.First}, {student.Last}: {student.Scores[0]}"));
    
    var groupByQuerry enum