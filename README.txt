1) Скачать библиотеку NuGet - слева нажать кнопку c 4 квадратиками (которая Extensions, Ctrl+Shift+X), вписать Nuget,
выбрать из появившегося списка строку NuGet Package Manager (jmrog), нажать install, выждать.
2) Перезагрузить VS Code! Иначе не сработает.
3) Выполните команду dotnet add package <package_name> в вашем терминале, где <package_name> - 
это название пакета NuGet, который вы хотите установить. В вашем случае, команда будет выглядеть 
примерно так: dotnet add package BenchmarkDotNet.

Теперь все команды позеленели.

Код один хер не работает, т.к. теперь запускается в режиме дебаг, а надо релиз.

4) Пишем в консоль (интегрированную)  dotnet build --configuration Release
Ждем чтобы появилась надпись "Сборка успешно завершена"

5) Идем в папку (как обычно в винде ходим, не через VS Code) 
занятие_9/TrueCode/bin/Release/net7.0, нажимаем файл TrueCode.exe, все запустится, 
отработают все тесты и даже выведутся все результаты на секундну и программа закончится. Рассмотреть ничего не успеем. 
Нужна пауза в самом конце проги.

Для этого в метода Main добавим две строки:

static void Main(string[] args)
        {
            BenchmarkRunner.Run<ListOfSortingBenchmark>();
            Console.WriteLine("Для завершения программы нажмите 0.");
            int stopCode = 1;
            while (stopCode == 1 ){stopCode = Convert.ToInt32(Console.Read());}
        }

6) Еще раз dotnet build --configuration Release и снова запускаем файл. Все работает, проверил.