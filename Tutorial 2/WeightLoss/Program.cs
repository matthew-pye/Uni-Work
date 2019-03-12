using System;

namespace WeightLoss
{
    class Program
    {
       
        static int _minsCycling, _minsRunning, _minsSwimming;

        static void Main(string[] args)
        {
            

            Console.WriteLine("How many mins were spent cycling?");
            _minsCycling = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("\nHow many mins were spent running?");
            _minsRunning = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("\nHow many mins were spent Swimming?");
            _minsSwimming = Convert.ToInt16(Console.ReadLine());

            Calculations();

        }

        static void Calculations()
        {

            double _calPerMinCycle = 3.33, _calPerMinRun = 7.91, _calPerMinSwim = 4.58;
            double _poundsLostCycle = 0, _poundsLostRun = 0, _poundsLostSwim = 0;
            double _calsBurntCycle, _calsBurntRun, _calsBurntSwim;
            int _hoursCycling = 0, _hoursRunning = 0, _hoursSwimming = 0;



            _calsBurntCycle = _minsCycling * _calPerMinCycle;
            _calsBurntSwim = _minsSwimming * _calPerMinSwim;
            _calsBurntRun = _minsRunning * _calPerMinRun;

            if (_calsBurntCycle >= 3500) { _poundsLostCycle = _calsBurntCycle / 3500; }
            if (_calsBurntCycle >= 3500) { _poundsLostSwim = _calsBurntSwim / 3500; }
            if (_calsBurntCycle >= 3500) { _poundsLostRun = _calsBurntRun / 3500; }
       

                do
                {
                    _hoursCycling++;
                    _minsCycling -= 60;
                } while (_minsCycling > 60);
            
                   
                do
                {
                    _hoursRunning++;
                    _minsRunning -= 60;
                } while (_minsRunning > 60);
           
                     
                do
                {
                    _hoursSwimming++;
                    _minsSwimming -= 60;
                } while (_minsSwimming > 60);
            
            PrintTable (_minsCycling, _minsRunning, _minsSwimming, _hoursCycling, _hoursRunning, _hoursSwimming, _calsBurntCycle, _calsBurntRun, _calsBurntSwim, _poundsLostCycle, _poundsLostRun, _poundsLostSwim);

        }

        static void PrintTable( int _minsCycling, int _minsRunning, int _minsSwimming, int _hoursCycling, int _hoursRunning, int _hoursSwimming, double _calsBurntCycle, double _calsBurntRun, double _calsBurntSwim, double _poundsLostCycle, double _poundsLostRun, double _poundsLostSwim)
        {
            Console.WriteLine("\n\nActivity \t Time Spent \t Calories burnt \t Pounds Lost");
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("Cycling \t {0}:{1} \t\t {2} \t\t {3}",_hoursCycling, _minsCycling, _calsBurntCycle, _poundsLostCycle);
            Console.WriteLine("Running \t {0}:{1} \t\t {2} \t\t {3}", _hoursRunning, _minsRunning, _calsBurntRun, _poundsLostRun);
            Console.WriteLine("Swimming \t {0}:{1} \t\t {2} \t\t {3}",_hoursSwimming, _minsSwimming, _calsBurntSwim, _poundsLostSwim);

            Console.ReadKey();
        }
    }
}
