
vars = [
['long', 'Id'],
['string','Alias'],
['string','Name'],
['string','Email'],
['string','ProfileImageLoc']
]

for var in vars:
    type = var[0]
    name = var[1]

    private = '_' + name[0].lower() + name[1:]
    
    print( """
            private %s %s;
            public %s %s
            {
                get
                {
                    return %s;
                }
                set
                {
                    if (this.%s != value)
                    {
                        this.%s = value;
                        this.NotifyPropertyChanged();
                    }
                }
            }
    """ % (type, private, type, name, private, private, private) )
    #print x