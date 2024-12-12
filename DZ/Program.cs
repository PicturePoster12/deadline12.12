using System;
namespace DZ
{
    class Program
    {
        static void Main()
        {
            #region Employee
            CEO timur = new CEO();
            FinanceDirector rashid = new FinanceDirector();
            AutomationDirector oIlham = new AutomationDirector();
            ITHead orkadiy = new ITHead();
            ITDeputy volodya = new ITDeputy();
            //SystemEngineers
            SystemsEngineer ilshat = new SystemsEngineer();
            SystemsEngineer ivanych = new SystemsEngineer();
            SystemsEngineer ilya = new SystemsEngineer();
            SystemsEngineer vitia = new SystemsEngineer();
            SystemsEngineer zhenya = new SystemsEngineer();
            //Developers
            Developer sergey = new Developer();
            Developer laysan = new Developer();
            Developer marat = new Developer();
            Developer dina = new Developer();
            Developer ildar = new Developer();
            Developer anton = new Developer();
            #endregion
            #region Tasks
            Task financeTask = new Task("Автоматизация бухгалтерского учета", Department.Finance);
            Task automationTask = new Task("Развертывание новой системы автоматизации", Department.Automation);
            Task itTask = new Task("Модернизация серверной инфраструктуры", Department.InformationTechnology);
            Task systemsTask = new Task("Настройка нового сервера", Department.Systems);
            Task developmentTask = new Task("Разработка нового приложения", Department.Development);
            #endregion
            Assign assign = new Assign();
            assign.AssignTask(timur, financeTask);
            assign.AssignTask(rashid, automationTask);
            assign.AssignTask(oIlham, itTask);
            assign.AssignTask(orkadiy, systemsTask);
            assign.AssignTask(sergey, developmentTask);
        }
    }
}