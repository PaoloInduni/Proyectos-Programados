import * as React from 'react';
import Image from "next/image";
import styles from "./page.module.css";
import { styled } from '@mui/material/styles';
import Container from '@mui/material/Container'
import Typography from '@mui/material/Typography'
import { Box } from "@mui/material";

import NavigationComponent from "./components/Navbar/NavigationComponent";

export default function Home() {
  return (
    <div className="App">

      <Container sx={{textAlign: "center"}} maxWidth="md">
          <Typography variant="h1" color="white" align="center" margin={10}>PAOLO INDUNI</Typography>
          <NavigationComponent/>
      </Container>

    </div>
  );
}