// Receives
Light light = new();
TV tv = new();

// Commands with receiver
ICommand turnOnLightCommand = new TurnOnLightCommand(light);
ICommand turnOffLightCommand = new TurnOffLightCommand(light);
ICommand volumeUpTVCommand = new VolumeUpTVCommand(tv);
ICommand volumeDownTVCommand = new VolumeDownTVCommand(tv);

// Invoker
VoiceController voiceController = new();

// Give commands
voiceController.Submit(turnOnLightCommand);
await Task.Delay(TimeSpan.FromMilliseconds(1));
voiceController.Submit(turnOffLightCommand);
await Task.Delay(TimeSpan.FromMilliseconds(1));
voiceController.Submit(volumeUpTVCommand);
await Task.Delay(TimeSpan.FromMilliseconds(1));
voiceController.Submit(volumeDownTVCommand);