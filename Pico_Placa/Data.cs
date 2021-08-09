
namespace Pico_Placa
{
    class Data
    {
        public string typeVehicle { get; set; }//Type of vehicle to know if it is allowed to move
        public string plate { get; set; }//license plate number 
        public string date { get; set; }//date selected
        public string time { get; set; }//time selected
        
        public Data(string typeVehicle, string plate, string date, string time) 
        {
            this.typeVehicle = typeVehicle;
            this.plate = plate;
            this.date = date;
            this.time = time;
        }
    }
}
