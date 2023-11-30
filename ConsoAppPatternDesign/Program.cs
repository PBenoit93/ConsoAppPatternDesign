using ConsoAppPatternDesign.Cannard;
using ConsoAppPatternDesign.Cannard.interfaces;
using ConsoAppPatternDesign.Cannard.tools;
using ConsoAppPatternDesign.demo;
using System.Security.Cryptography;


//activiteMarre();

void test()
{
    Desc1 d1 = new Desc1("toto");
    Desc1 d2 = new Desc1("dédé");

    Desc2 d3 = new Desc2(3);
    Desc2 d4 = new Desc2(5);


    d1.affiche();
    d1.affiche();
    d1.affiche();
    d1.affiche();

    d2.affiche();
    d2.affiche();
    d2.affiche();
    d2.affiche();

    d3.affiche();
    d3.affiche();
    d3.affiche();
    d3.affiche();
}

void activiteMarre()
{
    Canard[] canards = {
    new Colvert(),new Mandarin(),new Leurre(),new CanardPlastique()
};

    foreach (Canard canard in canards)
    {
        canard.cancan();
        canard.vol();
        Console.WriteLine("------------------");
    }

    Random rand = new Random(3);

    canards[0].setVol(new VolAReaction());
    foreach (var canard in canards)
    {
        canard.vol();
    }


    Console.WriteLine("*************************************");
    //canards[1].setCancan(new Begaille(cannards[1].getCancan()));

    //canards[1].setCancan(new Begaille(new AlternanceCri(
    //    new CoinCoin(),new Cancan()
    //    ))); 


    //cannards[1].setCancan(new Begaille(
    //    new AlternanceCri(
    //                        new CoinCoin(),
    //                        new Begaille(new CoinCoin())
    //                      )
    //));


    //Chasseur Dede = new Chasseur();

    //CanardAdapter colvert = new CanardAdapter(new Colvert());

    //Dede.vise(colvert);

    Colvert OColvert = new Colvert();   
    CanardAdapter colvert = new CanardAdapter(OColvert);


    OColvert.setCancan(criePlusieursFois(4, OColvert.getCancan()));

    colvert.crier();

    IComportementCancan criePlusieursFois(int nb, IComportementCancan bruit)
    {
        IComportementCancan cri = bruit;

        if (nb < 1)
        {
            cri = new Muet();
            return cri;
        }

        if (nb == 1)
        {
            return cri;
        }

        for (int i = 1; i < nb / 2; i++)
        {
            cri = addBruit(bruit, cri);
        }

        cri = new Begaille(cri);
        if (nb % 2 != 0)
        {
            cri = addBruit(cri, bruit);
        }

        return cri;
    }

    IComportementCancan addBruit(IComportementCancan bruit, IComportementCancan bruit2)
    {
        IComportementCancan cri = new Begaille(
             new AlternanceCri(
                 bruit,
                 bruit2
                 )
             );

        return cri;
    }

}



CanardVivant canardo = new CanardVivant(new Colvert());


ICanard canard = canardo;

canardo.afficher();
canard.afficher();

Console.WriteLine(canardo.getVie());
canardo.vol();
Console.WriteLine(canardo.getVie());

