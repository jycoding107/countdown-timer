<h2>Asp.Net MVC C# Countdown Timer Full Source Code</h2>
<p>In "/Home/Index.cshtml", when users input the hour,minute,second and then click on the Start button, the inputs are submitted to <code>PostCountdownTimer</code> action in <code>Home</code> controller. In the action, we get the end time by adding hour,minute,second to <code>DateTime.Now</code> and assign this end time value to <code>Session["EndTime"]</code>. Then, assign <code>Session["EndTime"]</code> value to <code>TempData["EndTime"]</code> because <code>TempData["EndTime"]</code> value is going to be used in the script section of "/Home/Index.cshtml" to calculate the duration of the time now with the TempData["EndTime"] and display the remaining time every single second.</p>
<h2>Video Demo</h2>
<p>Coming Soon</p>
<h2>Features</h2>
<p>
  <ul>
    <li>Enter Hour, Minute, Second that you need to be counting down from</li>
    <li>Display remaining time</li>
    <li>Display popup when times up</li>
    <li>Play audio when times up</li>
    <li>Reset Timer</li>
    </ul>
</p>
<h2>Screenshots</h2>
<p>
  <img src="https://padlet-uploads.storage.googleapis.com/432143275/742f38546d349c00354c9df4cfe5fb6a/image.png" />
  <img src="https://padlet-uploads.storage.googleapis.com/432143275/645c7327f77b74c4e1d375de391d5530/image.png" />
  <img src="https://padlet-uploads.storage.googleapis.com/432143275/fad51b690409d7148b7b6666a6446b8b/image.png" />
</p>
