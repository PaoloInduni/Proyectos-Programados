'use client'

import * as React from 'react';
import Box from '@mui/material/Box';
import { styled } from '@mui/material/styles';
import Paper from '@mui/material/Paper';
import Grid from '@mui/material/Grid2';
import Typography from '@mui/material/Typography'

const Item = styled(Paper)(({ theme }) => ({
  backgroundColor: '#fff',
  ...theme.typography.body2,
  padding: theme.spacing(1),
  textAlign: 'center',
  color: theme.palette.text.secondary,
  ...theme.applyStyles('dark', {
    backgroundColor: '#1A2027',
  }),
}));

export default function SimpleBottomNavigation() {
  const [value, setValue] = React.useState(0);

  return (
    <Box sx={{ backgroundColor: "#1b1b1b", display: "inline-flex", py: 2, px: 5}}>
      <Grid container spacing={10} columns={6}>
        <Grid size={2}>
          <Typography variant="h5" color="white">EXPERIENCE</Typography>
        </Grid>
        <Grid size={2}>
          <Typography variant="h5" color="white">EDUCATION</Typography>
        </Grid>
        <Grid size={2}>
          <Typography variant="h5" color="white">ABOUT ME</Typography>
        </Grid>
      </Grid>
    </Box>
  );
}
