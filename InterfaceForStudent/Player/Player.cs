using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAndDelegateHomeWork.Player
{

    /// <summary>
    /// Музыкальный плейер. 
    /// Должен содержать коллекцию треков List<Track>. 
    /// В классе Display должны отображаться: Номер трека, название, и данный момент времени. 
    /// </summary>
    internal interface IPlayer
    {



        /// <summary>
        /// Запускает цик работающий указанное в классе Track время. Если трек заканчивается, то вызывается метод NextTrack();
        /// </summary>
        void Play();

        /// <summary>
        /// Ставит трек на паузу. При нажатии на Play() воспроизводит с того-же места
        /// </summary>
        void Pause();

        /// <summary>
        /// Останавливает трек. При нажатии на Play() воспроизводит с первого трека коллекции
        /// </summary>
        void Stop();

        /// <summary>
        /// Воспроизводит следующий трек в коллекции
        /// </summary>
        void NextTrack();

        /// <summary>
        /// Воспроизводит предыдущий трек в коллекции
        /// </summary>
        void LastTrack();
    }
}
