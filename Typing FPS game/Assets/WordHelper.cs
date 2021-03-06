﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordHelper : MonoBehaviour {


    ArrayList verbs = new ArrayList();
    string[] verbArray = {"implement", "utilize", "integrate", "streamline", "optimize", "evolve", "transform", "embrace",
    "enable", "orchestrate", "leverage", "reinvent", "aggregate", "architect", "enhance", "incentivize", "morph", "empower",
    "envisioneer", "monetize", "harness", "facilitate", "seize", "disintermediate", "synergize", "strategize", "deploy",
    "brand", "grow", "target", "syndicate", "synthesize", "deliver", "mesh", "incubate", "engage", "maximize", "benchmark",
    "expedite", "reintermediate", "whiteboard", "visualize", "repurpose", "innovate", "scale", "unleash", "drive", "extend",
    "engineer", "revolutionize", "generate", "exploit", "transition", "e-enable", "iterate", "cultivate", "matrix",
    "productize", "redefine",
    "recontextualize" };

    ArrayList adjectives = new ArrayList();
    string[] adjArray = {"clicks-and-mortar", "value-added", "vertical", "proactive", "robust", "revolutionary", "scalable",
    "leading-edge", "innovative", "intuitive", "strategic", "e-business", "mission-critical", "sticky", "one-to-one",
    "24/7", "end-to-end", "global", "B2B", "B2C", "granular", "frictionless", "virtual", "viral", "dynamic", "24/365",
    "best-of-breed", "killer", "magnetic", "bleeding-edge", "web-enabled", "interactive", "dot-com", "sexy", "back-end",
    "real-time", "efficient", "front-end", "distributed", "seamless", "extensible", "turn-key", "world-class",
    "open-source", "cross-platform", "cross-media", "synergistic", "bricks-and-clicks", "out-of-the-box", "enterprise",
    "integrated", "impactful", "wireless", "transparent", "next-generation", "cutting-edge", "user-centric", "visionary",
    "customized", "ubiquitous", "plug-and-play", "collaborative", "compelling", "holistic", "rich" };

    ArrayList nouns = new ArrayList();
    string[] nounArray = {"synergies", "web-readiness", "paradigms", "markets", "partnerships", "infrastructures", "platforms",
    "initiatives", "channels", "eyeballs", "communities", "ROI", "solutions", "e-tailers", "e-services", "action-items",
    "portals", "niches", "technologies", "content", "vortals", "supply-chains", "convergence", "relationships",
    "architectures", "interfaces", "e-markets", "e-commerce", "systems", "bandwidth", "infomediaries", "models",
    "mindshare", "deliverables", "users", "schemas", "networks", "applications", "metrics", "e-business", "functionalities",
    "experiences", "web services", "methodologies" };

    

    // Use this for initialization
    void Start () {
        verbs.AddRange(verbArray);
        adjectives.AddRange(adjArray);
        nouns.AddRange(nounArray);

        GetResult();

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void GetResult()
    {
        int index1 = UnityEngine.Random.Range(0, verbs.Count - 1);
        int index2 = UnityEngine.Random.Range(0, adjectives.Count - 1);
        int index3 = UnityEngine.Random.Range(0, nouns.Count - 1);

        //Debug.Log(verbs[index1] + "..." + adjectives[index2] + "..." + nouns[index3]);

    }
    public string GetVerb()
    {
        int index1 = UnityEngine.Random.Range(0, verbs.Count - 1);
        return (string)verbs[index1];
    }
    public string GetAdjective()
    {
        int index2 = UnityEngine.Random.Range(0, adjectives.Count - 1);
        return (string)adjectives[index2];
    }
    public string GetNoun()
    {
        int index3 = UnityEngine.Random.Range(0, nouns.Count - 1);
        return (string)nouns[index3];
    }
}
