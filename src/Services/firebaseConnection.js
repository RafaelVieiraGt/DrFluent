import { initializeApp } from 'firebase/app';

import { getAuth } from 'firebase/auth';
import { getFirestore } from 'firebase/firestore';

const firebaseConfig = {
    apiKey: "AIzaSyBVbhisxTm79HGXaT2_eFhq0EzArOTQZH0",
    authDomain: "drfluentbeta.firebaseapp.com",
    projectId: "drfluentbeta",
    storageBucket: "drfluentbeta.appspot.com",
    messagingSenderId: "279083847373",
    appId: "1:279083847373:web:6e3a3963b1bb46d7b12384",
    measurementId: "G-M37J11NQY6"
  };

  const app = initializeApp(firebaseConfig);

// Inicializando banco e auth

const db = getFirestore(app);

const auth = getAuth(app);

export {db, auth};

