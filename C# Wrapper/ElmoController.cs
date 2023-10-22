using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using System;
using UnityEngine;

/*
 * C# Wrapper to control the Robot Elmo
 * Connects to the robot and allows users to send POSTS and GET requests to the robot
 * Only works if connected to the robot's hotspot 
 */
namespace ElmoController
{
    public class ElmoController
    {
        HttpClient client;
        const string ip = "10.42.0.1"; // replace with robot's ip - you get the ip from the companion app
        const string port = "8001";
        const string http = "http://";
        const string portIndicator = ":";

        public ElmoController()
        {
            // Initiate the HttpClient that will make the REST requests to the robot
            client = new HttpClient();
            const string baseAddress = http + ip + portIndicator + port;
            client.BaseAddress = new Uri(baseAddress);

            // Initial parameters values for the robot (may not be necessary? - need to test on robot)
            // Set each available value - list on github
            

            // Set the files needed to play the game
            // Set speech files
            // This is done in the Coompanion app I think, not here

        }

        // Update leds command
        // Sends the multidimensional array of LED colors to the robot via a POST request
        public async Task UpdateLeds(int[,] LEDColors)
        {
            UpdateLedsCommand command = new UpdateLedsCommand();
            command.colors = LEDColors;
            string jsonContentCommand = JsonUtility.ToJson(command);

            using StringContent jsonContent = new(jsonContentCommand, Encoding.UTF8,"application/json");

            await PostCommand(jsonContent);
        }

        // Puts Back in every position of the led array
        public int[,] BlackOutLED(int[,] LEDColors)
        {
            // LEDColors is a multidimensional array with 3 dimentions
            // first dimention is x
            // second dimention is y
            // third is the color of pixel at x,y

            for (int row = 0; row < 13; row++)
            {
                for (int col = 0; col < 13; col++)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        LEDColors[row * 13 + 12 - col, i] = 0; //black
                    }
                }
            }

            return LEDColors;
        }

        // Update leds icon command
        public async Task UpdateLedsIcon(string iconName)
        {
            UpdateLedsIconCommand command = new UpdateLedsIconCommand();
            command.name = iconName;
            string jsonContentCommand = JsonUtility.ToJson(command);
            using StringContent jsonContent = new(jsonContentCommand, Encoding.UTF8,"application/json");
            await PostCommand(jsonContent);
        }

        // Update update_wifi_credentials
        // We don't need this for our study because our robot uses ethernet cable I think
        // There's an e-mail about that by Henrique from idmind I think
        public async Task UpdateWifiCredentials(string ssid, string password)
        {
            UpdateWifiCredentialsCommand command = new UpdateWifiCredentialsCommand();
            command.ssid = ssid;
            command.password = password;
            string jsonContentCommand = JsonUtility.ToJson(command);
            using StringContent jsonContent = new(jsonContentCommand, Encoding.UTF8,"application/json");
            await PostCommand(jsonContent);
        }

        // Shut down command
        // Shuts the robot off
        public async Task Shutdown()
        {
            ShutdownCommand command = new ShutdownCommand();
            string jsonContentCommand = JsonUtility.ToJson(command);
            using StringContent jsonContent = new(jsonContentCommand, Encoding.UTF8,"application/json");
            await PostCommand(jsonContent);
        }

        // Enable Behavior Command
        public async Task EnableBehaviour(string behaviourName, bool controlValue)
        {
            EnableBehaviourCommand command = new EnableBehaviourCommand();
            command.name = behaviourName;
            command.control = controlValue; 
            string jsonContentCommand = JsonUtility.ToJson(command);
            using StringContent jsonContent = new(jsonContentCommand, Encoding.UTF8,"application/json");
            await PostCommand(jsonContent);
        }

        // Update Threshold Command
        public async Task UpdateTouchThreshold(int thresholdValue)
        {
            UpdateTouchThresholdCommand command = new UpdateTouchThresholdCommand();
            command.threshold = thresholdValue;
            string jsonContentCommand = JsonUtility.ToJson(command);
            using StringContent jsonContent = new(jsonContentCommand, Encoding.UTF8,"application/json");
            await PostCommand(jsonContent);
        }

        // Set Pan Torque Command
        public async Task SetPanTorque(bool controlValue)
        {
            SetPanTorqueComamnd command = new SetPanTorqueComamnd();
            command.control = controlValue; 
            string jsonContentCommand = JsonUtility.ToJson(command);
            using StringContent jsonContent = new(jsonContentCommand, Encoding.UTF8,"application/json");
            await PostCommand(jsonContent);
        }

        // Set Pan Torque Command
        public async Task SetTiltTorque(bool controlValue)
        {
            SetTiltTorqueCommand command = new SetTiltTorqueCommand();
            command.control = controlValue; 
            string jsonContentCommand = JsonUtility.ToJson(command);
            using StringContent jsonContent = new(jsonContentCommand, Encoding.UTF8,"application/json");
            await PostCommand(jsonContent);
        }

        // Set Pan Command
        public async Task SetPan(float angle)
        {
            SetPanCommand command = new SetPanCommand();
            command.angle = angle; 
            string jsonContentCommand = JsonUtility.ToJson(command);
            using StringContent jsonContent = new(jsonContentCommand, Encoding.UTF8,"application/json");
            await PostCommand(jsonContent);
        }

        // Set Pan with playtime Command
        public async Task SetPanWithPlaytime(float angle, float playtime)
        {
            SetPanWithPlaytimeCommand command = new SetPanWithPlaytimeCommand();
            command.angle = angle;
            command.playtime = playtime; 
            string jsonContentCommand = JsonUtility.ToJson(command);
            using StringContent jsonContent = new(jsonContentCommand, Encoding.UTF8,"application/json");
            await PostCommand(jsonContent);
        }

        // Set Tilt Command
        public async Task SetTilt(float angle)
        {
            SetTiltCommand command = new SetTiltCommand();
            command.angle = angle; 
            string jsonContentCommand = JsonUtility.ToJson(command);
            using StringContent jsonContent = new(jsonContentCommand, Encoding.UTF8,"application/json");
            await PostCommand(jsonContent);
        }

        // Set Tilt with playtime Command
        public async Task SetTiltWithPlaytime(float angle, float playtime)
        {
            SetTiltWithPlaytimeCommand command = new SetTiltWithPlaytimeCommand();
            command.angle = angle;
            command.playtime = playtime; 
            string jsonContentCommand = JsonUtility.ToJson(command);
            using StringContent jsonContent = new(jsonContentCommand, Encoding.UTF8,"application/json");
            await PostCommand(jsonContent);
        }

        // Set update_motor_limits Command
        public async Task UpdateMotorLimits(int panMin, int panMax, int tiltMin, int tiltMax)
        {
            UpdateMotorLimitsCommand command = new UpdateMotorLimitsCommand();
            command.pan_min = panMin; 
            command.pan_max = panMax; 
            command.tilt_min = tiltMin; 
            command.tilt_max = tiltMax; 
            string jsonContentCommand = JsonUtility.ToJson(command);
            using StringContent jsonContent = new(jsonContentCommand, Encoding.UTF8,"application/json");
            await PostCommand(jsonContent);
        }

        // Play Sound Command
        // The sound needs to be upload to the robot. I think this is done trhough the app. Then we can use this function to make the robot select and play that sound.
        public async Task PlaySound(string soundFileName)
        {
            PlaySoundCommand command = new PlaySoundCommand();
            command.name = soundFileName; 
            string jsonContentCommand = JsonUtility.ToJson(command);
            using StringContent jsonContent = new(jsonContentCommand, Encoding.UTF8,"application/json");

            await PostCommand(jsonContent);
        }

        // Play Speech Command
        // The speech needs to be upload to the robot. I think this is done trhough the app. Then we can use this function to make the robot select and play that speech.
        public async Task PlaySpeech(string speechFileName)
        {
            PlaySpeechCommand command = new PlaySpeechCommand();
            command.name = speechFileName; 
            string jsonContentCommand = JsonUtility.ToJson(command);
            using StringContent jsonContent = new(jsonContentCommand, Encoding.UTF8,"application/json");
            await PostCommand(jsonContent);
        }

        // Set volume Command
        public async Task SetVolume(int volumeValue)
        {
            SetVolumeCommand command = new SetVolumeCommand();
            command.volume = volumeValue; 
            string jsonContentCommand = JsonUtility.ToJson(command);
            using StringContent jsonContent = new(jsonContentCommand, Encoding.UTF8,"application/json");
            await PostCommand(jsonContent);
        }

        // Set screen Command
        public async Task SetScreen(string imageFileName, string textToShow, string urlToLoad, bool cameraFeed)
        {
            SetScreenCommand command = new SetScreenCommand();
            command.image = imageFileName;
            command.text = textToShow; 
            command.url = urlToLoad; 
            command.camera = cameraFeed;  
            string jsonContentCommand = JsonUtility.ToJson(command);
            using StringContent jsonContent = new(jsonContentCommand, Encoding.UTF8,"application/json");
            await PostCommand(jsonContent);
        }


        // GET and POST functions for REST Requests
        // GET function for REST Requests
        // Get deve ser para ir buscar os ficheiros
        async public Task<string> GetStatus() {
            string responseBody = "";
            try
            {
                using HttpResponseMessage response = await this.client.GetAsync("/status");
                response.EnsureSuccessStatusCode();
                responseBody = await response.Content.ReadAsStringAsync();
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }

            return responseBody;
        }

        // POST function for REST Requests
        async public Task PostCommand(HttpContent httpContent) {
            try
            {     
                var result = await client.PostAsync("/command", httpContent);
                result.EnsureSuccessStatusCode();
                string resultContent = await result.Content.ReadAsStringAsync();
                Console.WriteLine(resultContent);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
        }

    }
}
