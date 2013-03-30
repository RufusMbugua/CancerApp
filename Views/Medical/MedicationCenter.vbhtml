@Code
    ViewData("Title") = "Medication Center"
End Code

<h2>Medication Center</h2>
<form>
    <label>Name</label>
    <input type="text" name="name" placeholder="e.g Facility 1"/>
    <label>Location</label>
    <input type="text" name="name" placeholder="e.g Nairobi"/>
    <label>Details</label>
    <textarea name="details" placeholder="Write details here..."></textarea>
    <label>Address</label>
    <input type="text" name="address" placeholder="e.g 20000 Nbi"/>
    <label>Phone Number</label>
    <input type="tel" name="phoneNumber" placeholder="e.g 0700123456"/>
    <label>WebLink</label>
    <input type="url" name="webLink" placeholder="e.g www.example.com"/>
    <label>Email Address</label>
    <input type="email" name="emailAddress" placeholder="facility1@example.com"/>

    <input type="submit" value="Submit" />
</form>
