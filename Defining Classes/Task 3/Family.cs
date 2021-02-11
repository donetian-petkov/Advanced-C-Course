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
        int oldestAge = Int32.MinValue;
        Person oldestMember = new Person();

        foreach (var member in this.members)
        {
            if (member.Age > oldestAge)
            {
                oldestAge = member.Age;
                oldestMember = member;
            }
        }

        return oldestMember;
    }

}