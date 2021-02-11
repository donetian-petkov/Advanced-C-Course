using System;
using System.Collections.Generic;

public class Family
{
    public Family()
    {

    }

    private List<Person> members = new List<Person>();

    public void AddMember(Person member)
    {
        this.members.Add(member);
    }

    public Person GetOldestMember()
    {
        Person person = this.members
        .OrderByDescending(p => p.Age)
        .FirstOrDefault();

        return person;

    }

}